import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Product, GlobalVariable } from '../../app/models';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the PurchasePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-purchase',
  templateUrl: 'purchase.html',
})
export class PurchasePage {

  products : Product[];
  amountP : number;
  purchase :number;
  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad PurchasePage');
  }

  ionViewDidEnter() {
    this.http.get<Product[]>(GlobalVariable.host + "api/Product/GetAllProduct")
    .subscribe(data => {
      this.products = data;
    });
  }

  Purchase() {
    this.products.price *this
  }

}
