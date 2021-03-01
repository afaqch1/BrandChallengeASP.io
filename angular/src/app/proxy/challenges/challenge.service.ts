import type { ChallengeDto, CreateUpdateChallengeDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ChallengeService {
  apiName = 'Default';

  create = (input: CreateUpdateChallengeDto) =>
    this.restService.request<any, ChallengeDto>({
      method: 'POST',
      url: `/api/app/challenge`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/challenge/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ChallengeDto>({
      method: 'GET',
      url: `/api/app/challenge/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ChallengeDto>>({
      method: 'GET',
      url: `/api/app/challenge`,
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateChallengeDto) =>
    this.restService.request<any, ChallengeDto>({
      method: 'PUT',
      url: `/api/app/challenge/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
