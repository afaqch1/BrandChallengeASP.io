import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';


import { TrickRoutingModule } from './trick-routing.module';
import { TrickComponent } from './trick.component';


@NgModule({
  declarations: [TrickComponent],
  imports: [
    TrickRoutingModule,
    SharedModule
  ]
})
export class TrickModule { }
