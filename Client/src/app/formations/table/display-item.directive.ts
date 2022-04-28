import { Directive, HostBinding, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[appDisplayItem]'
})
export class DisplayItemDirective implements OnInit{

  @Input() hasStatus: string = '';

  @HostBinding("class") backgroundColor!: string;

  constructor() { }

  ngOnInit(): void {
    switch(this.hasStatus){
      case 'AFAIRE': this.backgroundColor = "bg-warning";break;
      case 'FAIT': this.backgroundColor = "bg-success";break;
      default: this.backgroundColor = "bg-light";break;
    }
  }


}
