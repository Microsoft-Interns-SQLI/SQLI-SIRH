import { Directive, HostBinding, HostListener, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[appDisplayItem]'
})
export class DisplayItemDirective implements OnInit{

  @Input() set appDisplayItem(status:string){
    switch(status){
      case 'AFAIRE': this.backgroundColor = "bg-warning";break;
      case 'FAIT': this.backgroundColor = "bg-success";this.textColor = "white";break;
      default: this.backgroundColor = "bg-light";break;
    }
  }
  
  @HostBinding("class") backgroundColor!: string;
  @HostBinding("style.color") textColor!: string;

  constructor() { }

  ngOnInit(): void {
    
  }


}
