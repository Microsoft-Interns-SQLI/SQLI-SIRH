import { Component, OnInit } from '@angular/core';
import { Job } from '../Models/Job';

@Component({
  selector: 'app-jobs-panel',
  templateUrl: './jobs-panel.component.html',
  styleUrls: ['./jobs-panel.component.css'],
})
export class JobsPanelComponent implements OnInit {
  dataJobsArray: Job[] = [];

  constructor() {}

  ngOnInit(): void {
    this.loadJobs();
  }

  private loadJobs() {
    this.dataJobsArray = [
      {
        id: 1,
        besoinEffectif: 45,
        salairePrevu: 1,
        label: 'Ingénieur Concepteur Développeur WPF (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 2, 24),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
      {
        id: 2,
        besoinEffectif: 34,
        salairePrevu: 2,
        label: 'Expert Technique .Net/Angular (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 3, 15),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
      {
        id: 3,
        besoinEffectif: 12,
        salairePrevu: 3,
        label: 'Développeur .Net/Front (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 3, 19),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
      {
        id: 4,
        besoinEffectif: 20,
        salairePrevu: 4,
        label: 'Expert Technique .Net/Azure (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 3, 24),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
      {
        id: 5,
        besoinEffectif: 60,
        salairePrevu: 5,
        label: 'Ingénieur Concepteur Développeur .Net (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 3, 24),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
      {
        id: 6,
        besoinEffectif: 24,
        salairePrevu: 6,
        label: 'Expert Technique .Net/AngularJs (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: true,
        dateCreation: new Date(2021, 3, 15),
        dateDebut: new Date(2022, 10, 4),
        dateFin: new Date(2022, 4, 25),
        typeContrat: 'CDI',
      },
      {
        id: 7,
        besoinEffectif: 90,
        salairePrevu: 7,
        label: 'Ingénieur Concepteur Développeur .Net & Azure (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 4, 23),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
      {
        id: 8,
        besoinEffectif: 15,
        salairePrevu: 8,
        label:
          'Ingénieur Concepteur Développeur Microsoft Dynamics CRM/365 (H/F)',
        entite: 'MAROC-ISC Maroc',
        isClosed: false,
        dateCreation: new Date(2021, 9, 6),
        dateDebut: new Date(2022, 3, 25),
        typeContrat: 'CDI',
      },
    ];
  }
}
