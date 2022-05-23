import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { Pagination } from 'src/app/Models/pagination';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit, OnChanges {

  @Input() pagination!: Pagination;
  @Output() pageNumber:EventEmitter<number> = new EventEmitter<number>()
  constructor() { }
  ngOnChanges(changes: SimpleChanges): void {
    console.log(this.pagination);
  }

  ngOnInit(): void {

  }

  pageChanged(even: any) {
    this.pageNumber.emit(even.page);
  }

}
