import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
/**
 * Generated class for the CalBmipagePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-cal-bmipage',
  templateUrl: 'cal-bmipage.html',
})
export class CalBmipagePage {
  height:number;
  weight:number;

  bmi:number;
 
  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {

  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CalBmipagePage');
  }

  calBmi(){
    this.http.get("http://localhost:5000/api/Pretestexam/QuestionI/"+this.weight+"/"+this.height).subscribe((data:number)=>{
    this.bmi = data
    });
  }

}
