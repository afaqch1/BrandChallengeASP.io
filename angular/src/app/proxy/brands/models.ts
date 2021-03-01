import type { AuditedEntityDto } from '@abp/ng.core';
import type { BrandType } from './brand-type.enum';

export interface BrandDto extends AuditedEntityDto<string> {
  name?: string;
  type: BrandType;
  description?: string;
}

export interface CreateUpdateBrandDto {
  name: string;
  type: BrandType;
  description: string;
}
