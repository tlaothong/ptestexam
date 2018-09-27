import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  name :string;
  serialnumber :string;  	
  unitprice :number;

  products :Product[];

  constructor(
       public navCtrl: NavController ,
       public http: HttpClient) {

        this.getProduct();
  }

  getProduct(){
    this.http.get("https://localhost:44339/api/QuestionIV/GetStoreProducts")
    .subscribe((data : Product[]) => {        
          this.products = data
      }, 
      error => {
          // ERROR: Do something
      });
  }

  addProduct(){
    let option = { "headers": { "Content-Type": "application/json" } };
    let model = {
        name : this.name,
        serialnumber : this.serialnumber,
        unitprice : this.unitprice
    }; // model here
    this.http.post("https://localhost:44339/api/QuestionIV/AddProduct", model, option)
      .subscribe((data:  Product[]) => {
        
          this.products = data
          this.name = "",
          this.serialnumber = "",
          this.unitprice =0

      }, error => {
        // If error
      });
  }


}

export class Product {
  public name :string;
  public serialNumber :string;  	
  public unitPrice :number;
}
