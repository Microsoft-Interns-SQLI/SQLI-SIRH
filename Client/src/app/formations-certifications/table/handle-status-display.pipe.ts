import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'handleStatusDisplay'
})
export class HandleStatusDisplayPipe implements PipeTransform {

  transform(value: string, ...args: unknown[]): string {
    switch(value){
      case 'AFAIRE': return "À Faire";
      case 'FAIT': return "Fait";
      default: return value;
    }
  }

}
