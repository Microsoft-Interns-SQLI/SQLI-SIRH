import { Component, OnDestroy, OnInit, Output } from '@angular/core';
import { Subscription } from 'rxjs';
import {
  Contrat,
  Niveau,
  Poste,
  RecruteMode,
  Site,
  SkillCenter,
} from '../Models/MdmModel';
import { MdmService } from '../services/mdm.service';

@Component({
  selector: 'app-mdm-panel',
  templateUrl: './mdm-panel.component.html',
  styleUrls: ['./mdm-panel.component.css'],
})
export class MdmPanelComponent implements OnInit, OnDestroy {
  sites!: Site[];
  postes!: Poste[];
  niveaux!: Niveau[];
  skillCenters!: SkillCenter[];
  modes!: RecruteMode[];
  contrats!: Contrat[];

  selectedItem: any;
  mdmData: any;
  mdmItems = [
    'Sites',
    'Postes',
    'Contrats',
    'Niveaux',
    'Skill Centers',
    'Modes de Recrutement',
  ];

  subscription?: Subscription;
  constructor(private mdmService: MdmService) {}
  ngOnDestroy(): void {
    //this.subscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.mdmService.getSites().subscribe((res) => (this.sites = res));
    this.mdmService.getPostes().subscribe((res) => (this.postes = res));
    this.mdmService.getNiveaux().subscribe((res) => (this.niveaux = res));
    this.mdmService
      .getSkillCenters()
      .subscribe((res) => (this.skillCenters = res));
    this.mdmService.getRecrutementMode().subscribe((res) => (this.modes = res));
    this.mdmService.getContrats().subscribe((res) => (this.contrats = res));
  }

  // handleDeleteSite(siteId: any) {
  //   this.mdmService.deleteSite(siteId).subscribe(() => {
  //     this.sites = this.sites?.filter((s) => s.id !== siteId);
  //   });
  // }

  // handleAddSite(site: any) {
  //   this.mdmService.addSite(site).subscribe((res) => this.sites.push(res));
  // }

  // handleDeletePoste(posteId: any) {
  //   this.mdmService.deletePoste(posteId).subscribe(() => {
  //     this.postes = this.postes?.filter((p) => p.id !== posteId);
  //   });
  // }

  // handleAddPoste(poste: any) {
  //   this.mdmService.addPoste(poste).subscribe((res) => this.postes.push(res));
  // }

  // handleDeleteNiveau(niveauId: any) {
  //   this.mdmService.deleteNiveau(niveauId).subscribe(() => {
  //     this.niveaux = this.niveaux?.filter((n) => n.id !== niveauId);
  //   });
  // }

  // handleAddNiveau(niveau: any) {
  //   this.mdmService
  //     .addNiveau(niveau)
  //     .subscribe((res) => this.niveaux.push(res));
  // }

  // handleDeleteSkillCenter(skillCenterId: any) {
  //   this.mdmService.deleteSkillCenter(skillCenterId).subscribe(() => {
  //     this.skillCenters = this.skillCenters?.filter(
  //       (n) => n.id !== skillCenterId
  //     );
  //   });
  // }

  // handleAddSkillCenter(skillCenter: any) {
  //   this.mdmService
  //     .addSkillCenter(skillCenter)
  //     .subscribe((res) => this.skillCenters.push(res));
  // }

  // handleDeleteMode(modeId: any) {
  //   this.mdmService.deleteMode(modeId).subscribe(() => {
  //     this.modes = this.modes?.filter((n) => n.id !== modeId);
  //   });
  // }

  // handleAddMode(mode: any) {
  //   this.mdmService.addMode(mode).subscribe((res) => this.modes.push(res));
  // }

  // handleDeleteContrat(contratId: any) {
  //   this.mdmService.deleteContrat(contratId).subscribe(() => {
  //     this.contrats = this.contrats?.filter((n) => n.id !== contratId);
  //   });
  // }

  // handleAddContrat(contrat: any) {
  //   this.mdmService
  //     .addContrat(contrat)
  //     .subscribe((res) => this.contrats.push(res));
  // }

  handleAdd(item: any) {
    switch (this.selectedItem) {
      case 'Postes':
        console.log('Emitted Postes');
        this.mdmService
          .addPoste(item)
          .subscribe((res) => this.postes.push(res));
        break;
      case 'Contrats':
        console.log('Emitted Contrats');
        this.mdmService
          .addContrat(item)
          .subscribe((res) => this.contrats.push(res));
        break;
      case 'Sites':
        console.log('Emitted Sites');
        this.mdmService.addSite(item).subscribe((res) => this.sites.push(res));
        break;
      case 'Niveaux':
        console.log('Emitted Niveaux');
        this.mdmService
          .addNiveau(item)
          .subscribe((res) => this.niveaux.push(res));
        break;
      case 'Skill Centers':
        console.log('Emitted Skill Centers');
        this.mdmService
          .addSkillCenter(item)
          .subscribe((res) => this.skillCenters.push(res));
        break;
      case 'Modes de Recrutement':
        console.log('Emitted Modes de Recrutement');
        this.mdmService.addMode(item).subscribe((res) => this.modes.push(res));
        break;

      default:
        break;
    }
  }

  handleDelete(itemId: any) {
    switch (this.selectedItem) {
      case 'Postes':
        console.log('Emitted Postes');
        this.mdmService.deletePoste(itemId).subscribe(() => {
          this.postes = this.postes?.filter((p) => p.id !== itemId);
          this.mdmData = this.postes;
        });
        break;
      case 'Contrats':
        console.log('Emitted Contrats');
        this.mdmService.deleteContrat(itemId).subscribe(() => {
          this.contrats = this.contrats?.filter((n) => n.id !== itemId);
          this.mdmData = this.contrats;
        });
        break;
      case 'Sites':
        console.log('Emitted Sites');
        this.mdmService.deleteSite(itemId).subscribe(() => {
          this.sites = this.sites?.filter((s) => s.id !== itemId);
          this.mdmData = this.sites;
        });
        break;
      case 'Niveaux':
        console.log('Emitted Niveaux');
        this.mdmService.deleteNiveau(itemId).subscribe(() => {
          this.niveaux = this.niveaux?.filter((n) => n.id !== itemId);
          this.mdmData = this.niveaux;
        });
        break;
      case 'Skill Centers':
        console.log('Emitted Skill Centers');
        this.mdmService.deleteSkillCenter(itemId).subscribe(() => {
          this.skillCenters = this.skillCenters?.filter((n) => n.id !== itemId);
          this.mdmData = this.skillCenters;
        });
        break;
      case 'Modes de Recrutement':
        console.log('Emitted Modes de Recrutement');
        this.mdmService.deleteMode(itemId).subscribe(() => {
          this.modes = this.modes?.filter((n) => n.id !== itemId);
          this.mdmData = this.modes;
        });
        break;

      default:
        break;
    }
  }

  onChange(item: any) {
    this.selectedItem = item.target.value;
    switch (item.target.value) {
      case 'Postes':
        console.log('Changed to Postes');
        this.mdmData = this.postes;
        break;
      case 'Contrats':
        console.log('Changed to Contrats');
        this.mdmData = this.contrats;
        break;
      case 'Sites':
        console.log('Changed to Sites');
        this.mdmData = this.sites;
        break;
      case 'Niveaux':
        console.log('Changed to Niveaux');
        this.mdmData = this.niveaux;
        break;
      case 'Skill Centers':
        console.log('Changed to Skill Centers');
        this.mdmData = this.skillCenters;
        break;
      case 'Modes de Recrutement':
        console.log('Changed to Modes de Recrutement');
        this.mdmData = this.modes;
        break;

      default:
        break;
    }
  }
}
