import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';
import { RouterLink } from '@angular/router';
@Component({
  selector: 'llamar-mesero',
  standalone: true,
  imports: [CommonModule, HeaderSecundarioComponent, FooterComponent, RouterLink],
  templateUrl: './llamar-mesero.component.html',
  styleUrl: './llamar-mesero.component.css',
})
export class LlamarMeseroComponent {
  cerrar = false;

  constructor(private router: Router) {}

  mostrarConfirmacion() {
    this.cerrar = true;
  }


}
