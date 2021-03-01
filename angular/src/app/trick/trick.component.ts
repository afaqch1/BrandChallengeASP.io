import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { TrickService, TrickDto,trickTypeOptions, TrickType } from '@proxy/tricks';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; // add this
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-trick',
  templateUrl: './trick.component.html',
  styleUrls: ['./trick.component.scss'],
  providers: [ListService],
})
export class TrickComponent implements OnInit {
  trick = { items: [], totalCount: 0 } as PagedResultDto<TrickDto>;
  selectedTrick = {} as TrickDto; // declare selectedBrand
  form: FormGroup; // add this line
  // add bookTypes as a list of BookType enum members
  trickTypes = trickTypeOptions;
  isModalOpen = false; // add this line

  constructor(public readonly list: ListService, private trickService: TrickService,private fb: FormBuilder,private confirmation: ConfirmationService) { }

  ngOnInit() {
    const trickStreamCreator = (query) => this.trickService.getList(query);

    this.list.hookToQuery(trickStreamCreator).subscribe((response) => {
      this.trick = response;
    });
  }
// add new method
createTrick() {
  this.selectedTrick={} as TrickDto;
  this.buildForm();
  this.isModalOpen = true;
}
// Add editBook method
editTrick(id: string) {
  this.trickService.get(id).subscribe((trick) => {
    this.selectedTrick = trick;
    this.buildForm();
    this.isModalOpen = true;
  });
}
// Add a delete method
delete(id: string) {
  this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
    if (status === Confirmation.Status.confirm) {
      this.trickService.delete(id).subscribe(() => this.list.get());
    }
  });
}
matchStrings(type:TrickType){
  if(this.trickService.matchStringsByType(type))
  {
    alert("You got 10 points");
  }
  else{
    alert("Better Luck next time babes!");
  }
}
// add buildForm method
buildForm() {
  this.form = this.fb.group({
    name: ['', Validators.required],
    type: [null, Validators.required],
  });
}
// add save method
save() {
  if (this.form.invalid) {
    return;
  }

  const request = this.selectedTrick.id
      ? this.trickService.update(this.selectedTrick.id, this.form.value)
      : this.trickService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
}
}
