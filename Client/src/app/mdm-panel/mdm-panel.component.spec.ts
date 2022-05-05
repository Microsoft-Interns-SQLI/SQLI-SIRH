import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MdmPanelComponent } from './mdm-panel.component';

describe('MdmPanelComponent', () => {
  let component: MdmPanelComponent;
  let fixture: ComponentFixture<MdmPanelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MdmPanelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MdmPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
