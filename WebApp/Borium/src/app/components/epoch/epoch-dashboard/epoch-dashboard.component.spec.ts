import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EpochDashboardComponent } from './epoch-dashboard.component';

describe('EpochDashboardComponent', () => {
  let component: EpochDashboardComponent;
  let fixture: ComponentFixture<EpochDashboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EpochDashboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EpochDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
