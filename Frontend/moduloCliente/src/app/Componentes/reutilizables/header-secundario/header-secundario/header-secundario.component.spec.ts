import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderSecundarioComponent } from './header-secundario.component';

describe('HeaderSecundarioComponent', () => {
  let component: HeaderSecundarioComponent;
  let fixture: ComponentFixture<HeaderSecundarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HeaderSecundarioComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HeaderSecundarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
