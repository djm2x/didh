import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FicheSyntheseComponent } from './fiche-synthese.component';

describe('FicheSyntheseComponent', () => {
  let component: FicheSyntheseComponent;
  let fixture: ComponentFixture<FicheSyntheseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FicheSyntheseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FicheSyntheseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
