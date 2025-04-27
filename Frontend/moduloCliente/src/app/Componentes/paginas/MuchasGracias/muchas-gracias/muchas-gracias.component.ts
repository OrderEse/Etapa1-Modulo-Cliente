import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';

@Component({
  selector: 'app-finalizar-interaccion',
  standalone: true,
  imports: [CommonModule, HeaderSecundarioComponent],
  templateUrl: './muchas-gracias.component.html',
  styleUrl: './muchas-gracias.component.css'
})
export class MuchasGraciasComponent {

  constructor(private router: Router) {}

  public volverInicio = () => {
    this.router.navigate(['/inicio']); // Navega a la página de inicio
  }
}
