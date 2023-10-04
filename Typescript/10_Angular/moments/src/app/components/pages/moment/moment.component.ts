import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {
  FormGroup,
  FormControl,
  Validators,
  FormGroupDirective,
} from '@angular/forms';
import { faTimes, faEdit } from '@fortawesome/free-solid-svg-icons';

import { MomentoService } from 'src/app/services/momento.service';
import { MessagesService } from 'src/app/services/messages.service';
import { CommentsService } from 'src/app/services/comments.service';
import { environment } from 'src/environments/environment';
import { Moment } from 'src/app/Moment';
import { Comment } from 'src/app/Comments';

@Component({
  selector: 'app-moment',
  templateUrl: './moment.component.html',
  styleUrls: ['./moment.component.css'],
})
export class MomentComponent implements OnInit {
  moment?: Moment;
  baseApiUrl: string = environment.baseApiUrl;

  faTimes = faTimes;
  faEdit = faEdit;

  commentForm!: FormGroup;

  constructor(
    private momentService: MomentoService,
    private route: ActivatedRoute,
    private messageService: MessagesService,
    private router: Router,
    private commentService: CommentsService
  ) {}

  async removeHandler(id: number) {
    await this.momentService.removeMoment(id).subscribe();

    this.messageService.add('Moment removed successfully');

    this.router.navigate(['/']);
  }

  ngOnInit(): void {
    // get Id from url
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.momentService.getMoment(id).subscribe((response) => {
      this.moment = response.data;
    });

    this.commentForm = new FormGroup({
      text: new FormControl('', [Validators.required]),
      username: new FormControl('', [Validators.required]),
    });
  }

  get text() {
    return this.commentForm.get('text')!;
  }

  get username() {
    return this.commentForm.get('username')!;
  }

  async onSubmit(formDirective: FormGroupDirective) {
    if (this.commentForm.invalid) {
      return;
    }

    const data: Comment = this.commentForm.value;

    data.momentId = Number(this.moment?.id);

    await this.commentService
    .createComment(data)
    .subscribe((comment) => this.moment!.comments!.push(comment.data!));
  
    this.messageService.add('Comment created successfully');

    // reset form
    this.commentForm.reset();

    formDirective.resetForm();
  }
}
