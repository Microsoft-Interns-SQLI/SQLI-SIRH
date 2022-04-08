import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImportCollabsComponent } from './import-collabs.component';

describe('ImportCollabsComponent', () => {
  let component: ImportCollabsComponent;
  let fixture: ComponentFixture<ImportCollabsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ImportCollabsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ImportCollabsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
