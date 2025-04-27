import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';  

@Component({
  selector: 'cerrar-cuenta',
  standalone: true,
  imports: [CommonModule, HeaderSecundarioComponent, FooterComponent],
  templateUrl: './cerrar-cuenta.component.html',
  styleUrl: './cerrar-cuenta.component.css'
})
export class CerrarCuentaComponent {
  
  public cerrar = false; // Variable para controlar el estado del boton de cerrar cuenta

  constructor(private router: Router) {}

  public mostrarConfirmacion = () => {
    this.cerrar = true; // Modifica el estado del boton de cerrar cuenta
  }

  public verMenu = () => {
    this.router.navigate(['/ver-menu']); // Navega a la página de llamar mesero
  }

  public volverInicio = () => {
    this.router.navigate(['/inicio']); // Navega a la página de inicio
  }

}
