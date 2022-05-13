import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillCenterComponent } from './skill-center.component';

describe('SkillCenterComponent', () => {
  let component: SkillCenterComponent;
  let fixture: ComponentFixture<SkillCenterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SkillCenterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SkillCenterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
