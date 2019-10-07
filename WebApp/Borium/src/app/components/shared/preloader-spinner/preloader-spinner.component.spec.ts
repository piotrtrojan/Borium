import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PreloaderSpinnerComponent } from './preloader-spinner.component';

describe('PreloaderSpinnerComponent', () => {
  let component: PreloaderSpinnerComponent;
  let fixture: ComponentFixture<PreloaderSpinnerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PreloaderSpinnerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PreloaderSpinnerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
