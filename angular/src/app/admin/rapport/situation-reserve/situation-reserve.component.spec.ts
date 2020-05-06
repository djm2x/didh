import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SituationReserveComponent } from './situation-reserve.component';

describe('SituationReserveComponent', () => {
  let component: SituationReserveComponent;
  let fixture: ComponentFixture<SituationReserveComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SituationReserveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SituationReserveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
