import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BarMecanismeComponent } from './bar-mecanisme.component';

describe('BarMecanismeComponent', () => {
  let component: BarMecanismeComponent;
  let fixture: ComponentFixture<BarMecanismeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BarMecanismeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BarMecanismeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
