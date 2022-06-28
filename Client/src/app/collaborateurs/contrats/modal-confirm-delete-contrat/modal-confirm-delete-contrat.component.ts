import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { CollabTypeContrat } from 'src/app/Models/CollabTypeContrat';
import { ContratsService } from 'src/app/services/contrats.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';

@Component({
  selector: 'app-modal-confirm-delete-contrat',
  templateUrl: './modal-confirm-delete-contrat.component.html'
})
@AutoUnsubscribe()
export class ModalConfirmDeleteContratComponent implements OnInit {
  @Input() contrat?: CollabTypeContrat;
  @Output() deleteContratEvent = new EventEmitter<number>();

  constructor(
    private contratsService: ContratsService
  ) { }

  ngOnInit(): void { }

  deleteContrat(idContrat: any) {
    // trick : to close the modal
    document.getElementById('btn-close-modal-delete-contrat')?.click();

    this.contratsService.deleteAffectation(idContrat).subscribe(() => {
      this.deleteContratEvent.emit(idContrat as number);
    });
  }
}
