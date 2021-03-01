import { mapEnumToOptions } from '@abp/ng.core';

export enum ChallengeType {
  Text = 0,
  Picture = 1,
  Video = 2,
  Undefined = 3,
}

export const challengeTypeOptions = mapEnumToOptions(ChallengeType);
