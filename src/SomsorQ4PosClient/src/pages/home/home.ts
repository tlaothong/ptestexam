import { OrdercreatePage } from './../ordercreate/ordercreate';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { Order, GlobalVarible } from '../../app/models';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  Orders: Order[];

  constructor(public navCtrl: NavController, private http: HttpClient) {

  }

  Create() {
    this.navCtrl.push(OrdercreatePage);
  }

  ionViewDidEnter() {
    this.http.get<Order[]>(GlobalVarible.host + "/api/Pos/List")
      .subscribe(data => {
        this.Orders = data;
      });
  }
}
