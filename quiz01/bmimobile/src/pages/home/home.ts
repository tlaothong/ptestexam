import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight: number = 0;
  height: number = 0;
  responseResult: any = {};

  constructor(public navCtrl: NavController, public http: HttpClient) {
  }

  calculate() {
    this.http.get("http://localhost:5000/api/bmi/" + this.weight + "/" + this.height).subscribe(
      it => {
        if (it != null) this.responseResult = it;
        else {
          this.responseResult.bmi = 0
          this.responseResult.message = "please insert weight and height more than 0."
        }
      });
  }

}
