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
    path: 'hacer-pedido',
    loadComponent: () =>
      import('./Componentes/paginas/HacerPedido/hacer-pedido/hacer-pedido.component').then(
        (m) => m.HacerPedidoComponent
      )
  },
  {
    path: 'pedido-realizado',
    loadComponent: () =>
      import('./Componentes/paginas/PedidoRealizado/pedido-realizado/pedido-realizado.component').then(
        (m) => m.PedidoRealizadoComponent
      )
  }
  
  
];
