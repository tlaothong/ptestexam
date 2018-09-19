import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the MyBmiPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-my-bmi',
  templateUrl: 'my-bmi.html',
})
export class MyBmiPage {

  weight: number;
  height: number;
  result: string;

  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad MyBmiPage');
  }

  public GetBMI()
  {
    this.http.get<string>("http://localhost:5000/api/bmi/getbmi/" + this.weight + "/" + this.height).subscribe(
      it => {
          // SUCCESS: Do something          
          console.log(it);
          this.result = it;
      }, 
      error => {
          // ERROR: Do something
          console.log(error);
          alert(error);                
      });
  }
}
