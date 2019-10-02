import { TestBed } from '@angular/core/testing';

import { EpochService } from './epoch.service';

describe('EpochService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EpochService = TestBed.get(EpochService);
    expect(service).toBeTruthy();
  });
});
