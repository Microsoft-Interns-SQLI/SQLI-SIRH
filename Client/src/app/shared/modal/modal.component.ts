import { Component, Input, OnInit } from '@angular/core';


@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})
export class ModalComponent implements OnInit {
  @Input()
  message?:string;

  @Input()
  isTrue?:boolean;
  
  constructor() { }

  ngOnInit(): void {
  }

}
