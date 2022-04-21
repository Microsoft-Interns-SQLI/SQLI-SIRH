import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  DetachedRouteHandle,
  RouteReuseStrategy,
} from '@angular/router';

export class CustomReuseStrategyService implements RouteReuseStrategy {
  private savedHandles = new Map<string, DetachedRouteHandle>();
  private sourceIsDetails: boolean = false;
  shouldAttach(route: ActivatedRouteSnapshot): boolean {
    return (
      this.savedHandles.has(this.getRouteKey(route)) && this.sourceIsDetails
    );
  }

  retrieve(route: ActivatedRouteSnapshot): DetachedRouteHandle | null {
    return this.savedHandles.get(this.getRouteKey(route)) || null;
  }

  shouldDetach(route: ActivatedRouteSnapshot): boolean {
    return route.data['saveComponent'];
  }

  shouldReuseRoute(
    future: ActivatedRouteSnapshot,
    curr: ActivatedRouteSnapshot
  ): boolean {
    if (
      future.routeConfig?.path === 'collaborateurs' &&
      curr.routeConfig?.path === 'addEditcollaborateur/:id'
    )
      this.sourceIsDetails = true;
    else this.sourceIsDetails = false;
    return future.routeConfig === curr.routeConfig;
  }

  store(route: ActivatedRouteSnapshot, handle: DetachedRouteHandle): void {
    const key = this.getRouteKey(route);
    this.savedHandles.set(key, handle);
  }

  // Routes are stored as an array of route configs, so we can find any with url property and join them to create the URL for the route
  private getRouteKey(route: ActivatedRouteSnapshot): string {
    return route.pathFromRoot
      .filter((u) => u.url)
      .map((u) => u.url)
      .join('/');
  }

  public clearSavedHandle(key: string): void {
    this.savedHandles.delete(key);
  }
}
