import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-momento-form',
  templateUrl: './momento-form.component.html',
  styleUrls: ['./momento-form.component.css']
})
export class MomentoFormComponent {
  @Input() btnText!: string;
}
