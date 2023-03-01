// ESSA CLASSE É UM ESPELHO DOS RETORNOS DA API-POKEMON

export class ApiReturn {
  info?: Infos[];
  results?: Results[];

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}

export class Infos {
  count?: number;
  pages?: number;
  next?: string;
  prev?: string;

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}

export class Results {
  id?: number;
  name?: string;
  status?: string;
  species?: string;
  type?: string;
  gender?: string;
  origin?: Origins[];
  location?: Locations[];
  image?: string;
  episode?: string[];
  url?: string;
  created?: Date;

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}

export class Origins {
  name?: string;
  url?: string;

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}

export class Locations {
  name?: string;
  url?: string;

  constructor(obj: Partial<ApiReturn>){
    Object.assign(this, obj);
  }
}
