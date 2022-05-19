import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NgSelectConfig } from '@ng-select/ng-select';
import { Niveau, Poste } from 'src/app/Models/MdmModel';
import {MdmService} from 'src/app/services/mdm.service';


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
  
  selectedPost:number | undefined;
  postFilter:number[] = [];
  postes!:Poste[];
  selectedNiveau:number | undefined;
  niveaux!:Niveau[];
  
  constructor(private mdmService:MdmService) { }

  ngOnInit(): void {
    this.mdmService.getPostes().subscribe((data)=>{
      console.log(data);
      this.postes = data;
    });
    this.mdmService.getNiveaux().subscribe((data)=>{
      console.log(data);
      this.niveaux = data;
    });
  }

  onSelect(){
    this.pageSize.emit(this.selected);
  }

  cll(string:any)
  {
    this.postFilter.push(string);
    console.log(this.postFilter);
  }

  onSearchChange(){
    this.search.emit(this.value);
  }

}
