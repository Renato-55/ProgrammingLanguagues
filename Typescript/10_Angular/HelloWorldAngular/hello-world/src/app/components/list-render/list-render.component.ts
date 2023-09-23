import { Component } from '@angular/core';
import { Animal } from 'src/app/models/Animal';

@Component({
  selector: 'app-list-render',
  templateUrl: './list-render.component.html',
  styleUrls: ['./list-render.component.scss'],
})
export class ListRenderComponent {
  animals: Animal[] = [
    {
      name: 'Bobbie',
      type: 'Dog',
      age: 3,
    },
    {
      name: 'Mittens',
      type: 'Cat',
      age: 2,
    },
    {
      name: 'Polly',
      type: 'Parrot',
      age: 4,
    },
  ];

  showAge(animal: Animal){
    alert(`${animal.name} is ${animal.age} years old`);
  }
}
