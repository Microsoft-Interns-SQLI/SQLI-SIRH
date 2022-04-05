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
  typeMessage?:string= "warning" || "danger" || "success" ;

  @Input()
  message?:string;

  ngOnInit(): void {
  }
  
  showToast()
  {

    var icoColor=""
    var toastColor="bg-"+this.typeMessage;
    if(this.typeMessage=="warning") {icoColor="#ffc107";this.title="Warning";}
    else if(this.typeMessage=="danger") {icoColor="#dc3545";this.title="Danger";}
    else if(this.typeMessage=="success") {icoColor="#198754";this.title="Success";}//#adb5bd
    else {icoColor="#0d6efd"; this.title="Information"; toastColor="bg-primary"}//#adb5bd

    var myToast:HTMLDivElement = document.getElementById("toast-div") as HTMLDivElement;
    myToast.setAttribute("class","show "+toastColor);
    
    var myIco = document.getElementById("icone") as HTMLElement;
    myIco.setAttribute("style","color : "+icoColor+";");
  }
  close()
  {
    var myToast:HTMLDivElement = document.getElementById("toast-div") as HTMLDivElement;
    myToast.setAttribute("class","toast fade hide");
  }
}
