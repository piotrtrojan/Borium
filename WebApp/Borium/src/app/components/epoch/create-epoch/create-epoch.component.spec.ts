import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEpochComponent } from './create-epoch.component';

describe('CreateEpochComponent', () => {
  let component: CreateEpochComponent;
  let fixture: ComponentFixture<CreateEpochComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateEpochComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateEpochComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
