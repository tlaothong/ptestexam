import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Product, GlobalVarible } from '../../app/models';
import { HttpClient } from '@angular/common/http';

@IonicPage()
@Component({
  selector: 'page-productcreate',
  templateUrl: 'productcreate.html',
})
export class ProductcreatePage {

  Product: Product;

  constructor(public navCtrl: NavController, public navParams: NavParams, private http: HttpClient) {
    this.Product = new Product();
  }

  Create() {
    this.http.post(GlobalVarible.host + "/api/Product/Create", JSON.stringify(this.Product), GlobalVarible.httpOptions)
      .subscribe(data => {
        this.navCtrl.popToRoot();
      });
  }
}