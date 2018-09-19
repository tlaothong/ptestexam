import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Item, GlobalVarible } from '../../app/models';
import { HttpClient } from '@angular/common/http';
/**
 * Generated class for the AddItemPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-add-item',
  templateUrl: 'add-item.html',
})
export class AddItemPage {

  item: Item = new Item;
  
 


  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient ) {
  }


  addItem(){
    
    this.http.post(GlobalVarible.host + "api/Store/AddItem", this.item)
      .subscribe(data => {

        console.log(data);
        this.navCtrl.pop();
      });
  }

  ionViewDidEnter() {
    this.item = this.navParams.data._item;
    
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AddItemPage');
  }

}
