import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  selected:number= 10;
  value:string = "";
  @Output() pageSize = new EventEmitter<number>();
  @Output() search = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void {
  }

  onSelect(){
    this.pageSize.emit(this.selected);
  }

  onSearchChange(){
    this.search.emit(this.value);
  }

}
