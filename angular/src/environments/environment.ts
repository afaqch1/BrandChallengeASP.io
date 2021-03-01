import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
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
    scope: 'offline_access openid profile role email phone BrandChallenge',
  },
  apis: {
    default: {
      url: 'https://localhost:44390',
      rootNamespace: 'BrandChallenge',
    },
  },
} as Environment;
