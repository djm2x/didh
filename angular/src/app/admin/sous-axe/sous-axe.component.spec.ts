import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { SousAxeComponent } from './sous-axe.component';

describe('SousAxeComponent', () => {
  let component: SousAxeComponent;
  let fixture: ComponentFixture<SousAxeComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ SousAxeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SousAxeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
