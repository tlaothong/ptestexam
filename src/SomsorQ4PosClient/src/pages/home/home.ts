import { OrdercreatePage } from './../ordercreate/ordercreate';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {

  }

  Create() {
    this.navCtrl.push(OrdercreatePage);
  }

  ionViewDidEnter() {
    // this.http.get<Product[]>(GlobalVarible.host + "/api/Product/List")
    //   .subscribe(data => {
    //     this.Products = data;
    //   });
  }
}
