import type { AuditedEntityDto } from '@abp/ng.core';
import type { ChallengeType } from './challenge-type.enum';

export interface ChallengeDto extends AuditedEntityDto<string> {
  name?: string;
  type: ChallengeType;
}

export interface CreateUpdateChallengeDto {
  name: string;
  type: ChallengeType;
}
