import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient, HttpHeaders } from '@angular/common/http';

/**
 * Generated class for the AddproductPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-addproduct',
  templateUrl: 'addproduct.html',
})
export class AddproductPage {
    
  productName:any;
  productSerial:any;
  productPrice:any;

  constructor(public navCtrl: NavController, private http: HttpClient) {

  }
  
  addProduct()
  {
     let option = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
    this.http.post("http://node19.codenvy.io:47107/api/Product/AddProduct", 
    {name : this.productName, serialNumber: this.productSerial,unitPrice: this.productPrice},
    option)
      .subscribe(data => {
        this.navCtrl.pop();
      });
  }
 
}
