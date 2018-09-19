import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NavController, NavParams, AlertController } from 'ionic-angular';
import { Item, GlobalVarible } from '../../app/models';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {

  items: Item[];
  amount: number = 0;
  totalPrice: number = 0;


  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient, public alertCtrl: AlertController) {
  }


  ionViewDidEnter() {
    this.items = [];
    this.http.get<Item[]>(GlobalVarible.host + "/api/Catalog/ListItems")
      .subscribe(data => {
        this.items = data;
        this.items.forEach(item => {
          item.isCheck = false;
        });
      });
  }

  Check(item: Item) {

    this.amount = 0;
    this.totalPrice = 0;

    if (item.isCheck != true) {
      item.isCheck = true;
    }
    else {
      item.isCheck = false;
    }

    this.items.forEach(item => {
      if (item.isCheck == true) {
        this.amount++
        this.totalPrice += item.price;
      }
    });
  }

  Purchase() {
    const confirm = this.alertCtrl.create({
      title: 'Confirm purchase?',
      message: 'Amount : ' + this.amount + '<br><br>Total price : ' + this.totalPrice,

      buttons: [
        {
          text: 'Cancel',
          handler: () => {
            console.log('Disagree clicked');
          }
        },
        {
          text: 'Confirm',
          handler: () => {
            this.items.forEach(item => {
              if (item.isCheck == true) {
                this.http.post(GlobalVarible.host + "/api/Catalog/DeleteItem/" + item.id, {})
                  .subscribe(data => {
                  });
              }
            });
            this.navCtrl.popToRoot();
          }
        }
      ]
    });
    confirm.present();
  }
}
