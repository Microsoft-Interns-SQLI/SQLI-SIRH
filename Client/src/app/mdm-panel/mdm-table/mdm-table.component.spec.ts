import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MdmTableComponent } from './mdm-table.component';

describe('MdmTableComponent', () => {
  let component: MdmTableComponent;
  let fixture: ComponentFixture<MdmTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MdmTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MdmTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
