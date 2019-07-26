import { TestBed } from '@angular/core/testing';

import { SugarLevelService } from './sugar-level.service';

describe('SugarLevelService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SugarLevelService = TestBed.get(SugarLevelService);
    expect(service).toBeTruthy();
  });
});
