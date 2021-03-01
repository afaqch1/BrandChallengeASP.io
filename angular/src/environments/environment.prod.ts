import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BrandChallenge',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44393',
    redirectUri: baseUrl,
    clientId: 'BrandChallenge_App',
    responseType: 'code',
    scope: 'offline_access BrandChallenge',
  },
  apis: {
    default: {
      url: 'https://localhost:44390',
      rootNamespace: 'BrandChallenge',
    },
  },
} as Environment;
