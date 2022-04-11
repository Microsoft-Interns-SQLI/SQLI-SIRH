import { transition } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { Chart, registerables } from 'chart.js';
import { environment } from 'src/environments/environment';

import { SpinnerComponent } from '../shared/spinner/spinner.component';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  private url: string = environment.URL;
  spinner : SpinnerComponent = new SpinnerComponent();

  constructor() { }

  ngOnInit() {
    this.showBar('barChart');
    this.showDonut("donutChart");
    this.showDonut("donutChart2");
    this.showPie('pieChart2');
    this.showPie("pieChart");
    this.showLine("lineChart")
  }

  showDonut(elementId: string) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'doughnut',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
          label: '# of Votes',
          data: [12, 19, 3, 5, 2, 3],
          backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
            'rgba(75, 192, 192, 0.2)',
            'rgba(153, 102, 255, 0.2)',
            'rgba(255, 159, 64, 0.2)'
          ],
          borderColor: [
            'rgba(255, 99, 132, 1)',
            'rgba(54, 162, 235, 1)',
            'rgba(255, 206, 86, 1)',
            'rgba(75, 192, 192, 1)',
            'rgba(153, 102, 255, 1)',
            'rgba(255, 159, 64, 1)'
          ],
          borderWidth: 1
        }]
      },
      options: {
        scales: {
          y: {
            beginAtZero: true
          }
        }
      }
    });
  }
  showPie(elementId: string) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'pie',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
          label: '# of Votes',
          data: [12, 19, 3, 5, 2, 3],
          backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
            'rgba(75, 192, 192, 0.2)',
            'rgba(153, 102, 255, 0.2)',
            'rgba(255, 159, 64, 0.2)'
          ],
          borderColor: [
            'rgba(255, 99, 132, 1)',
            'rgba(54, 162, 235, 1)',
            'rgba(255, 206, 86, 1)',
            'rgba(75, 192, 192, 1)',
            'rgba(153, 102, 255, 1)',
            'rgba(255, 159, 64, 1)'
          ],
          borderWidth: 1,
        }]
      },
      options: {
        scales: {
          y: {
            beginAtZero: true
          }
        }
      }
    });
  }
  showBar(elementId: string) {
    Chart.register(...registerables);
    const ctx = document.getElementById(elementId) as HTMLCanvasElement
    const myChart = new Chart(ctx, {
      type: 'bar',
      data: {
        labels: ['Female', 'Male'],
        datasets: [{
          label: '# of Votes',
          data: [39, 61],
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
            max:100,
            
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
          borderColor:'rgba(255, 70, 0, 1)',
          pointBorderColor:'rgba(255, 223, 0, 1)'
          
        }]
      },
      options: {
        scales: {
          y: {
            beginAtZero: true,
            
          }
        }
      }
    });
  }
}
