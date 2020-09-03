import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MyFirstAngularAppComponent } from './my-first-angular-app.component';

describe('MyFirstAngularAppComponent', () => {
  let component: MyFirstAngularAppComponent;
  let fixture: ComponentFixture<MyFirstAngularAppComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyFirstAngularAppComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyFirstAngularAppComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
