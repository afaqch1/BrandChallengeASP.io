import type { CreateUpdateTrickDto, TrickDto } from './models';
import type { TrickType } from './trick-type.enum';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TrickService {
  apiName = 'Default';

  create = (input: CreateUpdateTrickDto) =>
    this.restService.request<any, TrickDto>({
      method: 'POST',
      url: `/api/app/trick`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/trick/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, TrickDto>({
      method: 'GET',
      url: `/api/app/trick/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<TrickDto>>({
      method: 'GET',
      url: `/api/app/trick`,
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  matchStringsByType = (type: TrickType) =>
    this.restService.request<any, boolean>({
      method: 'POST',
      url: `/api/app/trick/match-strings`,
      params: { type: type },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateTrickDto) =>
    this.restService.request<any, TrickDto>({
      method: 'PUT',
      url: `/api/app/trick/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
