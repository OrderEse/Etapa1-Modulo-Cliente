import { Component } from '@angular/core';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';

@Component({
  selector: 'hacer-pedido',
  imports: [HeaderSecundarioComponent, FooterComponent],
  templateUrl: './hacer-pedido.component.html',
  styleUrl: './hacer-pedido.component.css'
})
export class HacerPedidoComponent {

}
