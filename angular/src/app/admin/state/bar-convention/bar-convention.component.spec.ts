import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BarConventionComponent } from './bar-convention.component';

describe('BarConventionComponent', () => {
  let component: BarConventionComponent;
  let fixture: ComponentFixture<BarConventionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BarConventionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BarConventionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
