import { mapEnumToOptions } from '@abp/ng.core';

export enum BrandType {
  FoodChain = 0,
  Beverages = 1,
  Confectioners = 2,
  Undefined = 3,
}

export const brandTypeOptions = mapEnumToOptions(BrandType);
