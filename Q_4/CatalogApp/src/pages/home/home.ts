import { AddProductPage } from './../add-product/add-product';
import { PurchasePage } from './../purchase/purchase';
import { ListPurchase, Product, GlobalVariable } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  products : Product[];
  listPurchasr : ListPurchase = new ListPurchase;
  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  ionViewDidEnter() {
    this.http.get<Product[]>(GlobalVariable.host + "api/Product/GetAllProduct")
    .subscribe(data => {
      this.products = data;
    });
  }

  purchase() {
    this.navCtrl.push(PurchasePage);

  }

  addProduct() {
    this.navCtrl.push(AddProductPage);
  }



}
