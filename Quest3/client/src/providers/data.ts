import { Injectable } from '@angular/core';

/*
  Generated class for the UserserviceProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class DataProvider {
  public Username : Picker[] = [];
  constructor() {
  }

}

export class Picker
{
    constructor(
        public Username: string,
        public PickNumber: number
    ){

    }
}