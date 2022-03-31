import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-toast',
  templateUrl: './toast.component.html',
  styleUrls: ['./toast.component.css']
})
export class ToastComponent implements OnInit {

  constructor() { }

  title?:string;

  @Input()
  typeMessage?:string;

  message?:string;

  ngOnInit(): void {
  }
  
  showToast()
  {// color: #0d6efd 
    var icoColor=""
    var toastColor="bg-"+this.typeMessage;
    if(this.typeMessage=="warning") {icoColor="#ffc107";this.title="Warning";}
    else if(this.typeMessage=="primary"){ icoColor="#0d6efd"; this.title="Information";}
    else if(this.typeMessage=="danger") {icoColor="#dc3545";this.title="Danger";}

    var myToast = document.getElementById("liveToast") as HTMLDivElement;
    myToast.setAttribute("class","show "+toastColor);
    
    var myIco = document.getElementById("myIco") as HTMLElement;
    myIco.setAttribute("style","color : "+icoColor+";");


  }
}
