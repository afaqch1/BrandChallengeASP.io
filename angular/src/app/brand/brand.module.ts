import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { BrandRoutingModule } from './brand-routing.module';
import { BrandComponent } from './brand.component';


@NgModule({
  declarations: [BrandComponent],
  imports: [
    BrandRoutingModule,
    SharedModule
  ]
})
export class BrandModule { }
