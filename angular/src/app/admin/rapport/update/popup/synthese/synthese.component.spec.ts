import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { SyntheseComponent } from './synthese.component';

describe('SyntheseComponent', () => {
  let component: SyntheseComponent;
  let fixture: ComponentFixture<SyntheseComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ SyntheseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SyntheseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
