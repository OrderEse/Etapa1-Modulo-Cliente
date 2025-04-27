import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CerrarCuentaComponent } from './cerrar-cuenta.component';

describe('CerrarCuentaComponent', () => {
  let component: CerrarCuentaComponent;
  let fixture: ComponentFixture<CerrarCuentaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CerrarCuentaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CerrarCuentaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
