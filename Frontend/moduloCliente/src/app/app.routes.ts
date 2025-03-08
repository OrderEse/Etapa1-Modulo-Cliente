import { Routes } from '@angular/router';

export const routes: Routes = [
 
  {
    path: '',
    redirectTo: 'inicio',
    pathMatch: 'full'
  },

  {
    path: 'inicio',
    loadComponent: () => import('./Componentes/inicio/inicio/inicio.component').then((m) => m.InicioComponent) //Lazy loading
  }
];
