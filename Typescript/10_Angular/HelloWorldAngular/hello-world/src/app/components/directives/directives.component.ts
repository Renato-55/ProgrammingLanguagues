import { Component } from '@angular/core';
import { NgStyle } from '@angular/common'; 

@Component({
  selector: 'app-directives',
  templateUrl: './directives.component.html',
  styleUrls: ['./directives.component.scss'],
})
export class DirectivesComponent {
  size = 40;
  font = 'Arial';
  color = 'green';

  classes = ['green-title', 'small-title'];

  underline = 'underline';
}
