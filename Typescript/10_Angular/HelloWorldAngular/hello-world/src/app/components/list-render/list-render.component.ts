import { Component } from '@angular/core';

@Component({
  selector: 'app-list-render',
  templateUrl: './list-render.component.html',
  styleUrls: ['./list-render.component.scss'],
})
export class ListRenderComponent {
  animals = [
    {
      name: 'Bobbie',
      type: 'Dog',
    },
    {
      name: 'Mittens',
      type: 'Cat',
    },
    {
      name: 'Polly',
      type: 'Parrot',
    },
  ];
  
}
