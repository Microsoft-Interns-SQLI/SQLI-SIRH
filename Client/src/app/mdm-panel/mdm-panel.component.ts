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

  handleDeleteSite(siteId: any) {
    this.mdmService.deleteSite(siteId).subscribe(() => {
      this.sites = this.sites?.filter((s) => s.id !== siteId);
    });
  }

  handleAddSite(site: any) {
    this.mdmService.addSite(site).subscribe((res) => this.sites.push(res));
  }

  handleDeletePoste(posteId: any) {
    this.mdmService.deletePoste(posteId).subscribe(() => {
      this.postes = this.postes?.filter((p) => p.id !== posteId);
    });
  }

  handleAddPoste(poste: any) {
    this.mdmService.addPoste(poste).subscribe((res) => this.postes.push(res));
  }

  handleDeleteNiveau(niveauId: any) {
    this.mdmService.deleteNiveau(niveauId).subscribe(() => {
      this.niveaux = this.niveaux?.filter((n) => n.id !== niveauId);
    });
  }

  handleAddNiveau(niveau: any) {
    this.mdmService
      .addNiveau(niveau)
      .subscribe((res) => this.niveaux.push(res));
  }

  handleDeleteSkillCenter(skillCenterId: any) {
    this.mdmService.deleteSkillCenter(skillCenterId).subscribe(() => {
      this.skillCenters = this.skillCenters?.filter(
        (n) => n.id !== skillCenterId
      );
    });
  }

  handleAddSkillCenter(skillCenter: any) {
    this.mdmService
      .addSkillCenter(skillCenter)
      .subscribe((res) => this.skillCenters.push(res));
  }

  handleDeleteMode(modeId: any) {
    this.mdmService.deleteMode(modeId).subscribe(() => {
      this.modes = this.modes?.filter((n) => n.id !== modeId);
    });
  }

  handleAddMode(mode: any) {
    this.mdmService.addMode(mode).subscribe((res) => this.modes.push(res));
  }

  handleDeleteContrat(contratId: any) {
    this.mdmService.deleteContrat(contratId).subscribe(() => {
      this.contrats = this.contrats?.filter((n) => n.id !== contratId);
    });
  }

  handleAddContrat(contrat: any) {
    this.mdmService
      .addContrat(contrat)
      .subscribe((res) => this.contrats.push(res));
  }
}
