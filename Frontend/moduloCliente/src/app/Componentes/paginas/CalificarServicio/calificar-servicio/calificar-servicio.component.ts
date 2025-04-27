import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { HeaderSecundarioComponent } from '../../../reutilizables/header-secundario/header-secundario/header-secundario.component';
import { FooterComponent } from '../../../reutilizables/footer/footer/footer.component';  
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';

@Component({
  selector: 'app-calificar-servicio',
  standalone: true,
  imports: [CommonModule, HeaderSecundarioComponent, FooterComponent, ReactiveFormsModule],
  templateUrl: './calificar-servicio.component.html',
  styleUrl: './calificar-servicio.component.css'
})
export class CalificarServicioComponent {

  public estrellas: number[] = [5, 4, 3, 2, 1];
  public formulario!: FormGroup;

  constructor(private router: Router, private formBuilder: FormBuilder){
    this.formulario = this.formBuilder.group({
      calificacion: [0],
      comentario: ['', [Validators.pattern(/^$|^[a-zA-Z0-9\s.,;:¡!¿?"'()\-\náéíóúÁÉÍÓÚñÑ]{10,500}$/)]]
    });
  }

  public enviarCalificacion = () => {
    console.log(this.formulario.getRawValue()); // Una vista previa de los datos
  }

  public volverInicio = () => {
    this.router.navigate(['/inicio']); // Navega a la página de inicio
  }

  public onRatingChange(nuevaCalificacion: number) {
    // Cambia la calificacion de estrellas en el form grup, y si se presiona 2 veces el mismo valor se entiende que quiere quitar la calificacion
    const calificacionActual = this.formulario.value.calificacion;
    this.formulario.patchValue({
      calificacion: calificacionActual === nuevaCalificacion ? 0 : nuevaCalificacion
    });
  }

}
