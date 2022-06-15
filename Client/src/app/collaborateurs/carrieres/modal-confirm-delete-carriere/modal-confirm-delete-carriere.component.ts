import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Carriere } from 'src/app/Models/Carriere';
import { CarrieresService } from 'src/app/services/carrieres.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';

@Component({
  selector: 'app-modal-confirm-delete-carriere',
  templateUrl: './modal-confirm-delete-carriere.component.html',
})
@AutoUnsubscribe()
export class ModalConfirmDeleteCarriereComponent implements OnInit {

  @Input() carriere?: Carriere;
  @Output() deleteCarriereEvent = new EventEmitter<number>();

  constructor(
    private carrieresService: CarrieresService
  ) { }

  ngOnInit(): void { }

  deleteCarriere(idCarriere: any) {
    // trick : to close the modal
    document.getElementById('btn-close-modal-delete-carriere')?.click();

    this.carrieresService.deleteCarriere(idCarriere).subscribe(() => {
      this.deleteCarriereEvent.emit(idCarriere as number);
    });
  }

}
