import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MainEpochComponent } from './main-epoch.component';

describe('MainEpochComponent', () => {
  let component: MainEpochComponent;
  let fixture: ComponentFixture<MainEpochComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainEpochComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainEpochComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
