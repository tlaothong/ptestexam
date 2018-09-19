import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the AddcatalogPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-addcatalog',
  templateUrl: 'addcatalog.html',
})
export class AddcatalogPage {

  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AddcatalogPage');
  }

  addcatalog(){
    this.http.get("api/"  )
    .subscribe(data => {
      //this.countM = data;
    });
  }
}
