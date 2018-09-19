import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  weight : number;
  height  : number;
  result : any;
  constructor(public navCtrl: NavController,public navParams: NavParams, public http: HttpClient) {
    console.log(this.weight,this.height);
  }
  Bmi() {
    //  this.result = Number(this.num1) + Number(this.num2);
     this.http.get("https://localhost:5001/api/Values/Bmirun/" + this.weight + "/" + this.height)
     .subscribe(data => {
       console.log(data);
       
       this.result = data;
  
     });
    }
}
