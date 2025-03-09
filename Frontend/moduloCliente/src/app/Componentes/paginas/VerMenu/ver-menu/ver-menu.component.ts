import { Component } from '@angular/core';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'ver-menu',
  standalone: true,
  imports: [HeaderSecundarioComponent, FooterComponent, CommonModule],
  templateUrl: './ver-menu.component.html',
  styleUrl: './ver-menu.component.css',
})
export class VerMenuComponent {
  mostrarImagenGrande: boolean = false;

  abrirImagen() {
    this.mostrarImagenGrande = true;
  }

  cerrarImagen() {
    this.mostrarImagenGrande = false;
  }
}
