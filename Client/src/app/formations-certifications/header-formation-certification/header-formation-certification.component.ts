import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-header-formation-certification',
  templateUrl: './header-formation-certification.component.html',
  styleUrls: ['./header-formation-certification.component.css']
})
export class HeaderFormationCertificationComponent implements OnInit, OnChanges {

  year: number = new Date(Date.now()).getFullYear();
  searchInput: string = "";
  status: number = 0;

  @Input() annees: number[] = [];
  @Output() statusYearEvent: EventEmitter<{ status: number, year: number }> = new EventEmitter<{ status: number, year: number }>();
  @Output() searchEvent: EventEmitter<string> = new EventEmitter<string>();

  statusTable = environment.status;

  constructor() { }

  ngOnInit(): void {
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.status = 0;
    this.year = new Date(Date.now()).getFullYear();
  }

  filter() {
    this.statusYearEvent.emit({ status: this.status, year: this.year });
  }

  onSearch() {
    this.searchEvent.emit(this.searchInput)
   }

}
