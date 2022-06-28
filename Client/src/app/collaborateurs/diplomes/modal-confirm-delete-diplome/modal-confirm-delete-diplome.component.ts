import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Diplome } from 'src/app/Models/MdmModel';
import { DiplomesService } from 'src/app/services/diplomes.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';

@Component({
  selector: 'app-modal-confirm-delete-diplome',
  templateUrl: './modal-confirm-delete-diplome.component.html'
})
@AutoUnsubscribe()
export class ModalConfirmDeleteDiplomeComponent implements OnInit {
  @Input() diplome?: Diplome;
  @Output() deleteDiplomesEvent = new EventEmitter<number>();

  constructor(
    private diplomesService: DiplomesService
  ) { }

  ngOnInit(): void {
  }

  deleteDiplome(idDiplome: any) {
    // trick : to close the modal
    document.getElementById('btn-close-modal-delete-diplome')?.click();

    this.diplomesService.deleteDiplome(idDiplome).subscribe(() => {
      this.deleteDiplomesEvent.emit(idDiplome as number)
    })
  }
}
