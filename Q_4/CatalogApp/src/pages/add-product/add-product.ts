import { GlobalVariable, Product } from './../../app/models';
import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the AddProductPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-add-product',
  templateUrl: 'add-product.html',
})
export class AddProductPage {

  name :string;
  serialNumber : string;
  price : number;
  products : Product = new Product;
  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AddProductPage');
  }

  AddProduct() {
    this.products.name = this.name;
    this.products.serial_number = this.serialNumber;
    this.products.price = this.price;

    this.http.post<Product>(GlobalVariable.host + "api/Product/AddProduct",this.products)
    .subscribe(data => {
      this.navCtrl.pop();
    });

  }

}
