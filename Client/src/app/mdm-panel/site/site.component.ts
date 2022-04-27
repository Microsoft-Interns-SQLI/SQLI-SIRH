import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Site } from 'src/app/Models/MdmModel';

@Component({
  selector: 'app-site',
  templateUrl: './site.component.html',
  styleUrls: ['./site.component.css'],
})
export class SiteComponent implements OnInit {
  @Input() sites!: Site[];
  @Output() siteToDelete = new EventEmitter<number>();
  @Output() siteToAdd = new EventEmitter<Site>();
  siteToDeleteId?: number;
  site!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}
  onDelete(site: any) {
    this.siteToDeleteId = site;
  }
  onConfirmDelete() {
    this.siteToDelete.emit(this.siteToDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.site.trim().length !== 0) {
      this.siteToAdd.emit({ name: this.site } as Site);
      this.site = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.site = '';
    this.isAdding = false;
  }
}
