import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight: number;
  height: number;
  bmi : number;
  output : string;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }

  CalcBMI() {
    this.http.get<number>("https://localhost:5001/api/Values/CalcBMI/" + this.weight + "/" + this.height)
      .subscribe(data => {
        this.bmi = data;
        if(this.bmi >= 18.5 || this.bmi <= 25){
          this.output = "You're within the normal weight range."
        }
        else{
          this.output = "You're underweight. You should consult your doctor!"
        }
      });
    }
}
