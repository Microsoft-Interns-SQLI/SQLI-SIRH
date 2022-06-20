import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NgSelectConfig } from '@ng-select/ng-select';
import { Niveau, Poste } from 'src/app/Models/MdmModel';
import { MdmService } from 'src/app/services/mdm.service';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {

  selected: number = 10;
  value: string = "";
  site: string = "";
  @Output() pageSize = new EventEmitter<number>();
  @Output() search = new EventEmitter<string>();

  chosenPost!: number;
  selectedPostes: number[] = [];
  postes!: Poste[];
  chosenNiveau!: number;
  selectedNiveaux: number[] = [];
  niveaux!: Niveau[];
  @Output() postesId = new EventEmitter<number[]>();
  @Output() niveauxId = new EventEmitter<number[]>();
  @Output() selectSite = new EventEmitter<string>();

  constructor(private mdmService: MdmService) { }

  ngOnInit(): void {
    this.mdmService.getAll("Postes").subscribe((data) => {
      // console.log(data);
      this.postes = data;
    });
    this.mdmService.getAll("Niveaux").subscribe((data) => {
      // console.log(data);
      this.niveaux = data;
    });
  }

  onSelect() {
    this.pageSize.emit(this.selected);
  }
  onSelectSite(){
    this.selectSite.emit(this.site);
  }
  onSearchChange() {
    this.search.emit(this.value);
  }
  onInputSearch() {
    console.log(this.value);
    if (this.value === "")
      this.search.emit("");
  }

  onPostesChange(postId: number) {
    this.selectedPostes = []
    this.selectedPostes.push(postId);
    this.postesId.emit(this.selectedPostes);
  }

  onNiveauxChange(niveauId: number) {
    this.selectedNiveaux = []
    this.selectedNiveaux.push(niveauId);
    this.niveauxId.emit(this.selectedNiveaux);
  }


}
