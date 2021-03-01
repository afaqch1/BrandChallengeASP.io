import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/brand-store',
        name: '::Menu:BrandChallenge',
        iconClass: 'fas fa-brand',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/brands',
        name: '::Menu:Brands',
        parentName: '::Menu:BrandChallenge',
        layout: eLayoutType.application,
        requiredPolicy: 'BrandChallenge.Brands',
      },
      {
        path: '/challenges',
        name: '::Menu:Challenges',
        parentName: '::Menu:BrandChallenge',
        layout: eLayoutType.application,
        requiredPolicy: 'BrandChallenge.Challenges',
      },
      {
        path: '/tricks',
        name: '::Menu:Tricks',
        parentName: '::Menu:BrandChallenge',
        layout: eLayoutType.application,
        requiredPolicy: 'BrandChallenge.Tricks',
      },
    ]);
  };
}
