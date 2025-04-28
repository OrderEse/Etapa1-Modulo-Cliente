import { Component } from '@angular/core';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'pedido-realizado',
  imports: [FooterComponent, HeaderSecundarioComponent, RouterLink],
  templateUrl: './pedido-realizado.component.html',
  styleUrl: './pedido-realizado.component.css'
})
export class PedidoRealizadoComponent {

}
