import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { ProgressCercleComponent } from './progress-cercle.component';

describe('ProgressCercleComponent', () => {
  let component: ProgressCercleComponent;
  let fixture: ComponentFixture<ProgressCercleComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ ProgressCercleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProgressCercleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
