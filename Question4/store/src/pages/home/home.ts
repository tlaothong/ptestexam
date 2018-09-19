import { Component } from '@angular/core';
import { NavController,NavParams } from 'ionic-angular';
import { AddItemPage } from '../add-item/add-item';
import { Item, GlobalVarible } from '../../app/models';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {


  item: Item[];
  constructor(public navCtrl: NavController, public http: HttpClient) {

  }

  
  ionViewDidEnter() {
    this.http.get<Item[]>(GlobalVarible.host + "/api/Store/ListItem")
      .subscribe(data => {
        this.item = data;
      });

  }


  Goadd(){
    this.navCtrl.push(AddItemPage);
  }
}
