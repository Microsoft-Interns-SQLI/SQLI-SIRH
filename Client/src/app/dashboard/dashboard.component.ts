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

  dashboard!: Dashboard ;

  constructor(private dahsboardService: DashboardService) { }

  ngOnInit() {
    /* this.showBar('barChart');
     this.showDonut("donutChart");
     this.showDonut("donutChart2");
     this.showPie('pieChart2');
     this.showPie("pieChart");
     this.showLine("lineChart")*/
    this.dahsboardService.getDashboard().subscribe((data: Dashboard) => {
      this.dashboard = data;
      console.log(data);
      this.CiviliteChart("barChart", this.dashboard.icdCount, this.dashboard.expertTechCount, this.dashboard.chefDeProjetCount, this.dashboard.managerCount);
      this.NiveauPieChart("niveauChart", this.dashboard.juniorCount, this.dashboard.operationnelCount, this.dashboard.confirmeCount, this.dashboard.seniorCount);
      this.PostsDonutChart("postChart", this.dashboard.icdCount, this.dashboard.expertTechCount, this.dashboard.chefDeProjetCount, this.dashboard.managerCount);
    });

  }

  showDonut() {

  }
  showPie(elementId: string) {

  }
  showBar(elementId: string, male: number, female: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'bar',
      data: {
        labels: ['Female', 'Male'],
        datasets: [{
          label: '# of Votes',
          data: [female, male],
          backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)'
          ],
          borderColor: [
            'rgba(255, 99, 132, 1)',
            'rgba(54, 162, 235, 1)'
          ],
          borderWidth: 1,

        }]
      },
      options: {
        scales: {
          yAxes: {
            beginAtZero: true,
            max: 100,

          }
        }
      }
    });
  }
  showLine(elementId: string) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'line',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
          label: '# of Votes',
          data: [12, 19, 3, 5, 2, 3],
          borderWidth: 1,
          borderColor: 'rgba(255, 70, 0, 1)',
          pointBorderColor: 'rgba(255, 223, 0, 1)'
        }]
      },
      options: {
        plugins: {
          title: {
            display: true,
            text: 'Chart Title',
          }
        },
        scales: {
          y: {
            beginAtZero: true,

          }
        }
      }
    });

  }

  PostsDonutChart(elementId: string, icd: number, expertTech: number, chefDeProjet: number, manager: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'doughnut',
      data: {
        labels: ['ICD', 'ET', 'Chef de projet', 'Manager'],
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
            position: 'top'
          },
        },
        scales: {
          y: {
            display:false
          }
        },
        responsive: true,
      }
    });
  }

  NiveauPieChart(elementId: string, junior: number, operationnel: number, confirme: number, senior: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'pie',
      data: {
        labels: ['Junior', 'Opérationnel', 'Confirmé', 'Sénior'],
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
            position: 'top'
          },
        },
        scales: {
          y: {
            display:false
          }
        },
        responsive: true,
      }
    });
  }

  CiviliteChart(elementId: string, icd: number, expertTech: number, chefDeProjet: number, manager: number) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'pie',
      data: {
        labels: ['ICD', 'ET','Chef de projet' , 'Manager'],
        datasets: [{
          label: '# of Votes',
          data: [icd, expertTech, chefDeProjet, manager],
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
            position: 'top'
          },
        },
        scales: {
          y: {
            display:false
          }
        },
        responsive: true,
      }
    });
  }


}
