import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { ChallengeRoutingModule } from './challenge-routing.module';
import { ChallengeComponent } from './challenge.component';


@NgModule({
  declarations: [ChallengeComponent],
  imports: [
    ChallengeRoutingModule,
    SharedModule
  ]
})
export class ChallengeModule { }
