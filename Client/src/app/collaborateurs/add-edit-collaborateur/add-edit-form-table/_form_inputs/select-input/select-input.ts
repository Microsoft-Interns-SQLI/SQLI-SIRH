export class SelectInputObject {
  value: number|string = "";
  display: number|string = "";

  constructor(val: number|string, dis: number|string) {
    this.value = val;
    this.display = dis;
  }
}

export class SelectInputData {
  data?: SelectInputObject[];
}
