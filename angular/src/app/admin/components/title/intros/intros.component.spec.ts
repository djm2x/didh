import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { IntrosComponent } from './intros.component';

describe('IntrosComponent', () => {
  let component: IntrosComponent;
  let fixture: ComponentFixture<IntrosComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ IntrosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IntrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
