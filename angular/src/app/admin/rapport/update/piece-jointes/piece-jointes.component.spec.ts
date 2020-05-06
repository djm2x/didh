import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PieceJointesComponent } from './piece-jointes.component';

describe('PieceJointesComponent', () => {
  let component: PieceJointesComponent;
  let fixture: ComponentFixture<PieceJointesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PieceJointesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PieceJointesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
