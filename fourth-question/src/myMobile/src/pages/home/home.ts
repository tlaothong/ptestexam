import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

import { PurchasePage } from '../purchase/purchase';
import { RegisterProductPage } from '../register-product/register-product';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  model: any = [];
  constructor(public navCtrl: NavController, private httpClient: HttpClient) {
  }

  ionViewDidEnter(){
    this.httpClient.get("https://localhost:5001/api/Values/GetProducts")
      .subscribe((data: any) => {
        this.model = data;
      }, error => {
        console.log("Home Error: " + JSON.stringify(error));
      });
  }
  doRefresh(refresher) {
    setTimeout(() => {

      this.httpClient.get("https://localhost:5001/api/Values/GetProducts")
        .subscribe((data: any) => {
          this.model = data;
        }, error => {
          console.log("Home Error: " + JSON.stringify(error));
        });

      refresher.complete();
    }, 2000);
  }

  registerproduct() {
    this.navCtrl.push(RegisterProductPage);
  }

  purchase() {
    this.navCtrl.push(PurchasePage);
  }

}
