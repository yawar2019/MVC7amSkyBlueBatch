import { TestBed } from '@angular/core/testing';

import { EmployeeShowService } from './employee-show.service';

describe('EmployeeShowService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EmployeeShowService = TestBed.get(EmployeeShowService);
    expect(service).toBeTruthy();
  });
});
