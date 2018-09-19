import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/timeout';

/*
  Generated class for the CatalogServiceProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class CatalogServiceProvider {
  baseUrl:string = "https://localhost:5001/api";
  constructor(public http: HttpClient) {
  }

  Search(key:string, value:string): Promise<any>{
    return this.http.get(this.baseUrl+'/catalog/search/'+key+'/'+value)
    .toPromise<any>();
  }

  AddProduct(product:any): Promise<any>{
    var options = { "headers": { "Content-Type": "application/json" } };
    return this.http.post(this.baseUrl+'/catalog/addproduct', product, options)
    .toPromise<any>();
  }
}
