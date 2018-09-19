import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/timeout';

/*
  Generated class for the BmiServiceProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class BmiServiceProvider {
  baseUrl:string = "https://localhost:5001/api";

  constructor(public http: HttpClient) {
    console.log('Hello BmiServiceProvider Provider');
  }

  Calculate(weight:number, height:number): Promise<any>{
    return this.http.get(this.baseUrl+'/calculator/'+weight+'/'+height)
    .toPromise<any>();
  }

}
