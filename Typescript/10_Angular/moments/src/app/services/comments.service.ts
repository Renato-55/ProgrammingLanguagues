import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Comment } from '../Comments';
import { Response } from '../Response';
@Injectable({
  providedIn: 'root'
})
export class CommentsService {
  private baseApiUrl: string = environment.baseApiUrl;
  private apiUrl: string = this.baseApiUrl + 'api/moments';

  constructor(private http: HttpClient) { }

  createComment(comment: Comment): Observable<Response<Comment>> {
    const url = `${this.apiUrl}/${comment.momentId}/comments`;
    return this.http.post<Response<Comment>>(url, comment);
  }
}
