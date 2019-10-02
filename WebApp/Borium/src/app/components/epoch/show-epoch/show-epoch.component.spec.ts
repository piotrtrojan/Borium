import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowEpochComponent } from './show-epoch.component';

describe('ShowEpochComponent', () => {
  let component: ShowEpochComponent;
  let fixture: ComponentFixture<ShowEpochComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowEpochComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowEpochComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
