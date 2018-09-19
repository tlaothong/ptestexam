import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  weight: number;
  height: number;
  bmi: number;
  guild: string;
  constructor(public navCtrl: NavController, public http: HttpClient) {


  }
  Cal() {
    // this.http.get("https://localhost:5001/api/values/Getbmi/" + this.weight + "/" + this.height)
    // .subscribe(it => {
    //     // SUCCESS: Do something
    //   },
    //   error => {
    //     console.log(error);
    //     // ERROR: Do something
    //   });

    this.bmi = (this.weight / (this.height * this.height)) * 703;
    if (this.bmi <= 18.5) {
      this.guild = "You're underweight. You should consult your doctor!";
      // console.log("You're underweight. You should consult your doctor!");
    } else if (this.bmi >= 18.5 && this.bmi <= 25) {
      this.guild = "You're within the normal weight range.";
      // console.log("You're within the normal weight range.");
    } else if (this.bmi > 18.5) {
      this.guild = "You're FATTTT. You should consult your doctor!";
      // console.log("You're FATTTT. You should consult your doctor!");
    }
  }
}
