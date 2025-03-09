import { Component, Input } from '@angular/core';

@Component({
  selector: 'Header-Secundario-Componente',
  imports: [],
  templateUrl: './header-secundario.component.html',
  styleUrl: './header-secundario.component.css'
})
export class HeaderSecundarioComponent {

  @Input() 
  public titulo: string = '';


}
