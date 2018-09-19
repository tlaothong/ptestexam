import { Item } from './../../app/models';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { GlobalVarible } from '../../app/models';

/**
 * Generated class for the ItemEditPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-item-edit',
  templateUrl: 'item-edit.html',
})
export class ItemEditPage {

  item: Item = new Item;

  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad ItemEditPage');
  }

  ionViewDidEnter() {
    this.item = new Item;
    this.http.get<Item>(GlobalVarible.host + "/api/Catalog/GetItem/" + this.navParams.data._id)
      .subscribe(data => {
        this.item = data;
      });
  }

  EditItem() {
    this.http.post(GlobalVarible.host + "/api/Catalog/EditItem", this.item)
      .subscribe(data => {
        this.navCtrl.pop();
      });
  }
}
