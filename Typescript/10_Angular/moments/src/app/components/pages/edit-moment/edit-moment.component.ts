import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Moment } from 'src/app/Moment';
import { MomentoService } from 'src/app/services/momento.service';

import { MessagesService } from 'src/app/services/messages.service';

@Component({
  selector: 'app-edit-moment',
  templateUrl: './edit-moment.component.html',
  styleUrls: ['./edit-moment.component.css'],
})
export class EditMomentComponent {
  moment!: Moment;
  btnText: string = 'Update Moment';

  constructor(
    private momentService: MomentoService,
    private route: ActivatedRoute,
    private router: Router,
    private messagesService: MessagesService
  ) {}

  ngOnInit(): void {
    const id: number = Number(this.route.snapshot.paramMap.get('id'));

    this.momentService.getMoment(id).subscribe((response) => {
      this.moment = response.data!;
    });
  }
  
  async editHandler(momentData: Moment) {
    const id = this.moment.id;

    const formData = new FormData();

    formData.append('title', momentData.title);
    formData.append('description', momentData.description);
    
    if (momentData.image) {
      formData.append('image', momentData.image);
    }

    await this.momentService.updateMoment(formData, id!).subscribe();
    
    this.messagesService.add('Moment updated successfully');
    
    this.router.navigate(['/']);
  }
}
