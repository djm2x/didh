import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { VisiteComponent } from './visite.component';

describe('VisiteComponent', () => {
  let component: VisiteComponent;
  let fixture: ComponentFixture<VisiteComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ VisiteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VisiteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
