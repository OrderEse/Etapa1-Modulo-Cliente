import { Component } from '@angular/core';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'hacer-pedido',
  imports: [
    HeaderSecundarioComponent,
    FooterComponent,
    CommonModule,
    FormsModule,
  ],
  templateUrl: './hacer-pedido.component.html',
  styleUrl: './hacer-pedido.component.css',
})
export class HacerPedidoComponent {


  // private router: Router;

  public mostrarImagenGrande: boolean = false;

  public pedidos: any[] = [
    { nombre: '', cantidad: 1 },
    { nombre: '', cantidad: 1 },
  ];

  constructor(private router: Router) {}

  agregarLinea() {
    this.pedidos.push({ nombre: '', cantidad: 1 });
  }

  public abrirModal(): void {
    this.mostrarImagenGrande = true;
  }

  public cerrarModal(): void {
    this.mostrarImagenGrande = false;
  }

  public hacerPedido() {
    const pedidosInvalidos = this.pedidos.filter(
      (pedido) => !pedido.nombre.trim()
    );


    if (pedidosInvalidos.length > 0) {
      alert(
        'Por favor, completá todos los nombres de platillos o bebidas antes de hacer el pedido.'
      );
      return;
    }

    alert('¡Pedido enviado exitosamente!');
    this.router.navigate(['/pedido-realizado']);
  }
}
