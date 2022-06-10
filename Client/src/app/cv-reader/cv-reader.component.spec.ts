import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CvReaderComponent } from './cv-reader.component';

describe('CvReaderComponent', () => {
  let component: CvReaderComponent;
  let fixture: ComponentFixture<CvReaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CvReaderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CvReaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
