import { Injectable } from '@angular/core';
import { Animal } from '../models/Animal';

@Injectable({
  providedIn: 'root'
})
export class ListService {

  constructor() { }

  remove(animals: Animal[], animal: Animal) {
    return animals.filter((a) => a.name !== animal.name);
  }
}
