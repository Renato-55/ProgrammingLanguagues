import { Component } from '@angular/core';
import { Animal } from 'src/app/models/Animal';
import { ListService } from 'src/app/service/list.service';

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

  constructor(private listService: ListService) {}

  showAge(animal: Animal) {
    alert(`${animal.name} is ${animal.age} years old`);
  }

  removeAnimal(animal: Animal) {
    this.animals = this.listService.remove(this.animals, animal);
  }
}
