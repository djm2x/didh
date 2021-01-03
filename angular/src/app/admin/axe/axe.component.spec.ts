import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AxeComponent } from './axe.component';

describe('AxeComponent', () => {
  let component: AxeComponent;
  let fixture: ComponentFixture<AxeComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AxeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AxeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
