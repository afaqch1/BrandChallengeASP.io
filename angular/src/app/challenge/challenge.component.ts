import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ChallengeService, ChallengeDto,challengeTypeOptions } from '@proxy/challenges';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; // add this
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-challenge',
  templateUrl: './challenge.component.html',
  styleUrls: ['./challenge.component.scss'],
  providers: [ListService],
})
export class ChallengeComponent implements OnInit {
  challenge = { items: [], totalCount: 0 } as PagedResultDto<ChallengeDto>;
  selectedChallenge = {} as ChallengeDto; // declare selectedBrand
  form: FormGroup; // add this line
  // add bookTypes as a list of BookType enum members
  challengeTypes = challengeTypeOptions;
  isModalOpen = false; // add this line

  constructor(public readonly list: ListService, private challengeService: ChallengeService,private fb: FormBuilder,private confirmation: ConfirmationService) { }

  ngOnInit() {
    const challengeStreamCreator = (query) => this.challengeService.getList(query);

    this.list.hookToQuery(challengeStreamCreator).subscribe((response) => {
      this.challenge = response;
    });
  }
  // add new method
   createChallenge() {
    this.selectedChallenge={} as ChallengeDto;
    this.buildForm();
    this.isModalOpen = true;
   }
   // Add editBook method
  editChallenge(id: string) {
    this.challengeService.get(id).subscribe((challenge) => {
      this.selectedChallenge = challenge;
      this.buildForm();
      this.isModalOpen = true;
    });
  }
  // Add a delete method
delete(id: string) {
  this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
    if (status === Confirmation.Status.confirm) {
      this.challengeService.delete(id).subscribe(() => this.list.get());
    }
  });
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

    const request = this.selectedChallenge.id
    ? this.challengeService.update(this.selectedChallenge.id, this.form.value)
    : this.challengeService.create(this.form.value);

  request.subscribe(() => {
    this.isModalOpen = false;
    this.form.reset();
    this.list.get();
  });
  }

}
