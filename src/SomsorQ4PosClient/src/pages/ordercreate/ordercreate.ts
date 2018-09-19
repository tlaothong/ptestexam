import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Order, GlobalVarible, ProductPurchase } from '../../app/models';
import { HttpClient } from '@angular/common/http';

@IonicPage()
@Component({
  selector: 'page-ordercreate',
  templateUrl: 'ordercreate.html',
})
export class OrdercreatePage {

  Order: Order;

  constructor(public navCtrl: NavController, public navParams: NavParams, private http: HttpClient) {
    this.Order = new Order();
  }

  Purchase(){
    this.http.post(GlobalVarible.host + "/api/Pos/Create", JSON.stringify(this.Order), GlobalVarible.httpOptions)
      .subscribe(data => {
        this.navCtrl.popToRoot();
      });
  }

  ionViewDidEnter() {
    this.http.get<ProductPurchase[]>(GlobalVarible.host + "/api/Product/List")
      .subscribe(data => {
        this.Order.products = data;
      });
  }
}
