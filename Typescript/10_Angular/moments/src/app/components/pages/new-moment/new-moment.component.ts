import { Component } from '@angular/core';
import { Moment } from 'src/app/Moment';
import { Router } from '@angular/router';
import { MessagesService } from 'src/app/services/messages.service';
import { MomentoService } from 'src/app/services/momento.service';
@Component({
  selector: 'app-new-moment',
  templateUrl: './new-moment.component.html',
  styleUrls: ['./new-moment.component.css']
})
export class NewMomentComponent {
  public btnText: string = 'Create Moment';

  constructor(private momentService: MomentoService, private messageService: MessagesService, private router: Router) { }

  async createHandler(moment: Moment) {
    const formData = new FormData();

    formData.append('title', moment.title);
    formData.append('description', moment.description);
    
    if (moment.image) {
      formData.append('image', moment.image);
    }

    await this.momentService.createMoment(formData).subscribe();

    this.messageService.add('Moment Created whit sucess');

    this.router.navigate(['/']);
  }
}
