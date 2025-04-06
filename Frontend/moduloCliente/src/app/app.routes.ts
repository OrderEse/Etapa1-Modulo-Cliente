import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'inicio',
    pathMatch: 'full',
  },

  {
    path: 'inicio',
    loadComponent: () =>
      import('./Componentes/paginas/Inicio/inicio/inicio.component').then(
        (m) => m.InicioComponent
      ), //Lazy loading
  },

  {

    path: 'ver-menu',
    loadComponent: () => import('./Componentes/paginas/VerMenu/ver-menu/ver-menu.component').then(
      (m) => m.VerMenuComponent
    ),
  },

  {
    path: 'llamar-mesero',
    loadComponent: () =>
      import('./Componentes/paginas/LlamarMesero/llamar-mesero/llamar-mesero.component').then(
        (m) => m.LlamarMeseroComponent
      ),
  },
  

  {
    path: 'cerrar-cuenta',
    loadComponent: () =>
      import('./Componentes/paginas/CerrarCuenta/cerrar-cuenta/cerrar-cuenta.component').then(
        (m) => m.CerrarCuentaComponent
      ),
  }

];
