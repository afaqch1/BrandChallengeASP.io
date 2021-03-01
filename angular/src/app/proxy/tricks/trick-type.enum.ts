import { mapEnumToOptions } from '@abp/ng.core';

export enum TrickType {
  Text = 0,
  Picture = 1,
  Video = 2,
  Undefined = 3,
}

export const trickTypeOptions = mapEnumToOptions(TrickType);
