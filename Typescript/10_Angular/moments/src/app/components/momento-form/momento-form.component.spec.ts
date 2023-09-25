import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MomentoFormComponent } from './momento-form.component';

describe('MomentoFormComponent', () => {
  let component: MomentoFormComponent;
  let fixture: ComponentFixture<MomentoFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MomentoFormComponent]
    });
    fixture = TestBed.createComponent(MomentoFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
