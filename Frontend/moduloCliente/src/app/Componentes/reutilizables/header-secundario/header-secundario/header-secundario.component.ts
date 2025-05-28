import { Component, Input } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'Header-Secundario-Componente',
  imports: [],
  templateUrl: './header-secundario.component.html',
  styleUrl: './header-secundario.component.css'
})
export class HeaderSecundarioComponent {

  @Input() 
  public titulo: string = '';

  constructor(private location: Location) {}

  public volverAlAnterior = () => {
    this.location.back(); // Regresa a la página anterior en el historial
  }
}
