import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Qa400',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44336',
    redirectUri: baseUrl,
    clientId: 'Qa400_App',
    responseType: 'code',
    scope: 'offline_access Qa400',
  },
  apis: {
    default: {
      url: 'https://localhost:44336',
      rootNamespace: 'Qa400',
    },
  },
} as Config.Environment;
