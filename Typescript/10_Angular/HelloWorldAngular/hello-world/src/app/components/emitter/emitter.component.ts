import { Component } from '@angular/core';

@Component({
  selector: 'app-emitter',
  templateUrl: './emitter.component.html',
  styleUrls: ['./emitter.component.scss']
})
export class EmitterComponent {
  myNumber: number = 0;

  onChangeNumber(value: number) {
    this.myNumber = value;
  }
}
