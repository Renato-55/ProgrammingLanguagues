import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Moment } from 'src/app/Moment';

@Component({
  selector: 'app-momento-form',
  templateUrl: './momento-form.component.html',
  styleUrls: ['./momento-form.component.css'],
})
export class MomentoFormComponent implements OnInit {
  @Input() btnText!: string;
  @Input() momentData: Moment | null = null;
  @Output() onSubmit = new EventEmitter<Moment>();
  momentForm!: FormGroup;

  ngOnInit() {
    this.momentForm = new FormGroup({
      id: new FormControl(this.momentData ? this.momentData.id : ''),
      title: new FormControl(this.momentData ? this.momentData.title : '', [
        Validators.required,
      ]),
      description: new FormControl(
        this.momentData ? this.momentData.description : '',
        [Validators.required]
      ),
      image: new FormControl(this.momentData ? this.momentData.image : ''),
    });
  }

  get title() {
    return this.momentForm.get('title')!;
  }

  get description() {
    return this.momentForm.get('description')!;
  }
  onFileSelected(event: any) {
    const file = event.target.files[0];

    // patch value is used to set the value of the form control
    this.momentForm.patchValue({ image: file });
  }

  submit() {
    if (this.momentForm.invalid) {
      return;
    }
    this.onSubmit.emit(this.momentForm.value);
  }
}
