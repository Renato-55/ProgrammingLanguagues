import { Component, OnInit } from '@angular/core';
import { MomentoService } from 'src/app/services/momento.service';
import { Moment } from 'src/app/Moment';
import { environment } from 'src/environments/environment';

import { faSearch } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  allMoments: Moment[] = [];
  moments: Moment[] = [];
  baseApiUrl: string = environment.baseApiUrl;

  // todo search
  faSearch = faSearch;
  searchTerm: string = '';

  constructor(private momentService: MomentoService) {}

  ngOnInit(): void {
    this.momentService.getMoments().subscribe((response) => {
      const data = response.data;

      data?.map((item) => {
        item.created_at = new Date(item.created_at!).toLocaleDateString(
          'pt-PT'
        );
      });
      this.allMoments = data!;
      this.moments = data!;
    });
  }

  search(e: Event): void {
    const target = e.target as HTMLInputElement;
    const value = target.value;

    this.moments = this.allMoments.filter((moment) =>
      moment.title.toLowerCase().includes(value.toLowerCase())
    );
  }
}
