import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Animal } from 'src/app/models/Animal';

import { ListService } from '../service/list.service';
@Component({
  selector: 'app-item-detail',
  templateUrl: './item-detail.component.html',
  styleUrls: ['./item-detail.component.scss']
})
export class ItemDetailComponent {
  animal?: Animal;

  constructor(private route: ActivatedRoute, private listService: ListService) {
    this.getAnimal();
  }

  getAnimal(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.listService.getItem(id)
      .subscribe(animal => this.animal = animal);
  }
}
