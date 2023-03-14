import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PatientbasicrecordComponent } from './patientbasicrecord.component';

describe('PatientbasicrecordComponent', () => {
  let component: PatientbasicrecordComponent;
  let fixture: ComponentFixture<PatientbasicrecordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PatientbasicrecordComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PatientbasicrecordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
