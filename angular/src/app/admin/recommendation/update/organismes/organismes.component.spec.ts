import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { OrganismesComponent } from './organismes.component';

describe('OrganismesComponent', () => {
  let component: OrganismesComponent;
  let fixture: ComponentFixture<OrganismesComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ OrganismesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrganismesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
