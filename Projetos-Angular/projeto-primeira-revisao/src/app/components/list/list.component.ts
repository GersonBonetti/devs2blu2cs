import { ApiReturn, Results } from './../../models/api-return';
import { ApiService } from './../../service/api.service';
import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  public resultsList$ = new Subject<Results[] | undefined>();

  constructor(public service: ApiService) { }

  ngOnInit(): void {
    this.service.getCharactersList().subscribe(
      (resp) => {
        console.log(resp);
        this.resultsList$.next(resp.results);
      }
    );
  }
}
