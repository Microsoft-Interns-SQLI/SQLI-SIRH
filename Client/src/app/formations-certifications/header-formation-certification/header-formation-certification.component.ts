import { Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { Niveau, Poste } from 'src/app/Models/MdmModel';
import { MdmService } from 'src/app/services/mdm.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-header-formation-certification',
  templateUrl: './header-formation-certification.component.html',
  styleUrls: ['./header-formation-certification.component.css']
})
export class HeaderFormationCertificationComponent implements OnInit, OnChanges, OnDestroy {

  year: number = new Date(Date.now()).getFullYear();
  searchInput: string = "";
  status: number = 0;

  @Input() annees: number[] = [];
  @Output() statusYearEvent: EventEmitter<{ status: number, year: number }> = new EventEmitter<{ status: number, year: number }>();
  @Output() searchEvent: EventEmitter<string> = new EventEmitter<string>();
  @Output() postesEvent: EventEmitter<number[]> = new EventEmitter<number[]>();
  @Output() niveauxEvent: EventEmitter<number[]> = new EventEmitter<number[]>();

  statusTable = environment.status;

  postes!: Poste[];
  chosenPost!: number;
  selectedPostes: number[] = [];

  niveaux!: Niveau[];
  chosenNiveau!: number;
  selectedNiveaux: number[] = [];

  subPost!:Subscription;
  subNiveau!:Subscription;
  
  constructor(private mdmService : MdmService) { }
 

  ngOnInit(): void {
    this.subPost = this.mdmService.getAll("Postes").subscribe((data) => {
      this.postes = data;
    });
    this.subNiveau = this.mdmService.getAll("Niveaux").subscribe((data) => {
      this.niveaux = data;
    });
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
  onChangeSearch(){
    if(this.searchInput === ""){
      this.searchEvent.emit("");
    }
  }
  onPostesChange(postId: number) {
    this.selectedPostes = []
    this.selectedPostes.push(postId);
    this.postesEvent.emit(this.selectedPostes);
  }

  onNiveauxChange(niveauId: number) {
    this.selectedNiveaux = []
    this.selectedNiveaux.push(niveauId);
    this.niveauxEvent.emit(this.selectedNiveaux);
  }

  ngOnDestroy(): void {
    this.subNiveau.unsubscribe();
    this.subPost.unsubscribe();
  }

}
