import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MuchasGraciasComponent } from './muchas-gracias.component';

describe('FinalizarInteraccionComponent', () => {
  let component: MuchasGraciasComponent;
  let fixture: ComponentFixture<MuchasGraciasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MuchasGraciasComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MuchasGraciasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
