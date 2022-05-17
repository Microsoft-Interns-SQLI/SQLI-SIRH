import { Component, OnInit } from '@angular/core';
import { Chart, registerables } from 'chart.js';
import { Dashboard } from '../Models/Dashboard';
import { DashboardService } from '../services/dashboard.service';



@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  dashboard: Dashboard = {} as Dashboard;

  constructor(private dahsboardService: DashboardService) { }

  ngOnInit() {
    this.dahsboardService.getDashboard().subscribe((data: Dashboard) => {
      this.dashboard = data;
      console.log(data);
      this.NiveauPieChart("niveauChart", this.dashboard.juniorCount, this.dashboard.operationnelCount, this.dashboard.confirmeCount, this.dashboard.seniorCount);
      this.PostsDonutChart("postChart", this.dashboard.icdCount, this.dashboard.expertTechCount, this.dashboard.chefDeProjetCount, this.dashboard.managerCount);
      this.HeadDonutChart("headChart", this.dashboard.maleCount, this.dashboard.femaleCount);
    });

  }


  PostsDonutChart(elementId: string, icd: number, expertTech: number, chefDeProjet: number, manager: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement;
    Chart.defaults.font.weight = 'bold';
    const myChart = new Chart(ctx, {
      type: 'doughnut',
      data: {
        labels: [icd + ' ICD', expertTech + ' ET', chefDeProjet + ' Chef de projet', manager + ' Manager'],
        datasets: [{
          label: '# of Votes',
          data: [icd, expertTech, chefDeProjet, manager],
          backgroundColor: [
            'rgba(248, 192, 200, 1)',
            'rgba(239, 231, 211, 1)',
            'rgba(211, 187, 221, 1)',
            'rgba(236, 227, 240, 1)'
          ],
          borderColor: [
            'rgba(248, 192, 200, 1)',
            'rgba(239, 231, 211, 1)',
            'rgba(211, 187, 221, 1)',
            'rgba(236, 227, 240, 1)'
          ],
          borderWidth: 1,
          hoverOffset: 4
        }]
      },
      options: {
        animation: {
          duration: 1000,
          easing: 'linear',
        },
        plugins: {
          legend: {
            display: true,
            position: 'top',
            labels: {
              font: {
                size: 13,
              },
            },
          },
        },
        scales: {
          y: {
            display: false
          }
        },
        responsive: true,
      }
    });
  }

  NiveauPieChart(elementId: string, junior: number, operationnel: number, confirme: number, senior: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement;
    Chart.defaults.font.weight = 'bold';
    const myChart = new Chart(ctx, {
      type: 'pie',
      data: {
        labels: [junior + ' Junior', operationnel + ' Opérationnel', confirme + ' Confirmé', senior + ' Sénior'],
        datasets: [{
          label: '# of Votes',
          data: [junior, operationnel, confirme, senior],
          backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
            'rgba(75, 192, 192, 0.2)'
          ],
          borderColor: [
            'rgba(255, 99, 132, 1)',
            'rgba(54, 162, 235, 1)',
            'rgba(255, 206, 86, 1)',
            'rgba(75, 192, 192, 1)'
          ],
          borderWidth: 1,
          hoverOffset: 4
        }]
      },
      options: {
        animation: {
          duration: 1000,
          easing: 'linear',
        },
        plugins: {
          legend: {
            display: true,
            position: 'top',
            labels: {
              font: {
                size: 13,
              },
            },
          },
        },
        scales: {
          y: {
            display: false
          }
        },
        responsive: true,
      }
    });
  }

  HeadDonutChart(elementId: string, males: number, females: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement;
    Chart.defaults.font.weight = 'bold';
    const myChart = new Chart(ctx, {
      type: 'doughnut',
      data: {
        labels: [males + ' Males', females + ' Females'],
        datasets: [{
          label: '# of Votes',
          data: [males, females],
          backgroundColor: [
            'rgba(71, 235, 164, 0.5)',
            'rgba(240, 117, 136, 0.5)'
          ],
          borderColor: [
            'rgba(71, 235, 164, 1)',
            'rgba(240, 117, 136, 1)'
          ],
          borderWidth: 1,
          hoverOffset: 4
        }]
      },
      options: {
        animation: {
          duration: 1000,
          easing: 'linear',//display: true, position: 'top',

        },
        plugins: {
          legend: {
            display: true,
            position: 'top',
            labels: {
              font: {
                size: 13,
              }
            }
          },
        },
        scales: {
          y: {
            display: false
          },
        },
        responsive: true,
      }
    });
  }


}
