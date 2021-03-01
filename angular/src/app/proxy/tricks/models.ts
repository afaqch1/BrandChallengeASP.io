import type { TrickType } from './trick-type.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateTrickDto {
  name: string;
  type: TrickType;
}

export interface TrickDto extends AuditedEntityDto<string> {
  name?: string;
  type: TrickType;
}
