import { TestBed } from '@angular/core/testing';

import { ResourcemanagerService } from './resourcemanager.service';

describe('ResourcemanagerService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ResourcemanagerService = TestBed.get(ResourcemanagerService);
    expect(service).toBeTruthy();
  });
});
