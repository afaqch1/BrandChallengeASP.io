import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { BrandService, BrandDto,brandTypeOptions } from '@proxy/brands';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; // add this
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.scss'],
  providers: [ListService],
})
export class BrandComponent implements OnInit {
  brand = { items: [], totalCount: 0 } as PagedResultDto<BrandDto>;
  selectedBrand = {} as BrandDto; // declare selectedBrand
  form: FormGroup; // add this line

  // add bookTypes as a list of BookType enum members
  brandTypes = brandTypeOptions;
  isModalOpen = false; // add this line

  constructor(public readonly list: ListService, private brandService: BrandService,private fb: FormBuilder,private confirmation: ConfirmationService) { }

  ngOnInit() {
    const brandStreamCreator = (query) => this.brandService.getList(query);

    this.list.hookToQuery(brandStreamCreator).subscribe((response) => {
      this.brand = response;
    });
  }
   // add new method
   createBrand() {
    this.selectedBrand={} as BrandDto;
    this.buildForm();
    this.isModalOpen = true;
  }
  // Add editBook method
  editBrand(id: string) {
    this.brandService.get(id).subscribe((brand) => {
      this.selectedBrand = brand;
      this.buildForm();
      this.isModalOpen = true;
    });
  }
  // Add a delete method
delete(id: string) {
  this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
    if (status === Confirmation.Status.confirm) {
      this.brandService.delete(id).subscribe(() => this.list.get());
    }
  });
}
  // add buildForm method
  buildForm() {
    this.form = this.fb.group({
      name: ['', Validators.required],
      type: [null, Validators.required],
      description: [null, Validators.required],
    });
  }
  // add save method
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedBrand.id
      ? this.brandService.update(this.selectedBrand.id, this.form.value)
      : this.brandService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

}
