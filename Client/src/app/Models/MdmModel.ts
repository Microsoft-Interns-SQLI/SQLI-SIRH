class BaseMDM {
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
}

export class Poste extends BaseMDM {
  id: number = 0;
  name: string = "";
}
export class Niveau extends BaseMDM {
  id: number = 0;
  name: string = "";
}
export class RecruteMode extends BaseMDM {
  id: number = 0;
  mode: string = "";
}

export class Diplome extends BaseMDM {
  id: number = 0;

}

