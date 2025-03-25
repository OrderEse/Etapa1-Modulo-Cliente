import { ComponentFixture, TestBed } from '@angular/core/testing';
import { LlamarMeseroComponent } from './llamar-mesero.component';

describe('LlamarMeseroComponent', () => {
  let component: LlamarMeseroComponent;
  let fixture: ComponentFixture<LlamarMeseroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LlamarMeseroComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(LlamarMeseroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
