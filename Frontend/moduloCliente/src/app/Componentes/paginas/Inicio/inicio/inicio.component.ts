import { Component } from '@angular/core';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';
import { RouterLink } from '@angular/router';
@Component({
  selector: 'app-inicio',
  imports: [FooterComponent, RouterLink],
  templateUrl: './inicio.component.html',
  styleUrl: './inicio.component.css',
})
export class InicioComponent {

}
