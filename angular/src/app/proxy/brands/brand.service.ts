import type { BrandDto, CreateUpdateBrandDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class BrandService {
  apiName = 'Default';

  create = (input: CreateUpdateBrandDto) =>
    this.restService.request<any, BrandDto>({
      method: 'POST',
      url: `/api/app/brand`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/brand/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, BrandDto>({
      method: 'GET',
      url: `/api/app/brand/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<BrandDto>>({
      method: 'GET',
      url: `/api/app/brand`,
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateBrandDto) =>
    this.restService.request<any, BrandDto>({
      method: 'PUT',
      url: `/api/app/brand/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
