import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the BmiPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-bmi',
  templateUrl: 'bmi.html',
})
export class BmiPage {
  data1:number;
  data2:number;
  results:number;

  constructor(public navCtrl: NavController
    , public navParams: NavParams, public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad BmiPage');
  }
  add(){
    this.http
      .get<number>("/http://localhost:5000/api/values")
      .subscribe(it => {
        this.results = (+this.data1+ +this.data2);
        console.log(it)
      });
    }

}
