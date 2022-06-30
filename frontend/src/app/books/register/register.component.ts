import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
})
export class RegisterComponent {
  public formGroup: FormGroup;
  public submit: boolean = false;
  constructor(private formBuilder: FormBuilder) {
    this.formGroup = formBuilder.group({
      title: ['', [Validators.required]],
      isbn: ['', [Validators.required]],
    });
  }

  public onSubmit() {
    this.submit = true;
  }

  public get titleControl() {
    return this.formGroup.controls['title'];
  }

  public get isbnControl() {
    return this.formGroup.controls['isbn'];
  }
}
