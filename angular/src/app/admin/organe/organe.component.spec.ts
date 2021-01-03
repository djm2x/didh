import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { OrganeComponent } from './organe.component';

describe('OrganeComponent', () => {
  let component: OrganeComponent;
  let fixture: ComponentFixture<OrganeComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ OrganeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrganeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
