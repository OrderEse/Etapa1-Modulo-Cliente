import { Component } from '@angular/core';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'hacer-pedido',
  imports: [HeaderSecundarioComponent, FooterComponent, CommonModule, FormsModule],
  templateUrl: './hacer-pedido.component.html',
  styleUrl: './hacer-pedido.component.css'
})
export class HacerPedidoComponent {

  public mostrarImagenGrande: boolean = false;

  public pedidos: any[] = [
    {nombre: '', cantidad: 1},
    {nombre: '', cantidad: 1}
  ];


  public agregarLinea() : void {
    this.pedidos.push({nombre: '', cantidad: 1});
  };


  public abrirModal() : void {
    this.mostrarImagenGrande = true;
  };

  public cerrarModal() : void {
    this.mostrarImagenGrande = false;
  };

}
