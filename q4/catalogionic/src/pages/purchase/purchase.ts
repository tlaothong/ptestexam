import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Item } from '../../app/model';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the PurchasePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-purchase',
  templateUrl: 'purchase.html',
})
export class PurchasePage {
  items: Item[];  
  constructor(public navCtrl: NavController, public navParams: NavParams,private httpClient: HttpClient) {
  }
  ionViewWillEnter(){
    this.httpClient.get("http://localhost:8000/api/catalog/GetCatalogs")
    .subscribe((data: any) => {
      this.items = data;
      //alert(JSON.stringify(data));
    }, error => {
      // If error
    });
  }
  ionViewDidLoad() {
    console.log('ionViewDidLoad PurchasePage');
  }

}
