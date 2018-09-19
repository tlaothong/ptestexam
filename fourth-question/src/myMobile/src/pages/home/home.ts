import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

import { PurchasePage } from '../purchase/purchase';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  model: any = [];
  constructor(public navCtrl: NavController, private httpClient: HttpClient) {
  }

  ionViewDidLoad() {
    this.httpClient.get("https://localhost:5001/api/Values/GetProducts")
      .subscribe((data: any) => {
        this.model = data;
      }, error => {
        console.log("Home Error: " + JSON.stringify(error));
      });
  }

  purchase(){
    this.navCtrl.push(PurchasePage);
  }

}
