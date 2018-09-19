import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  Weight: number;
  Height: number;

  HeightP2: number;
  BMI: number;
  Result: string;

  constructor(public navCtrl: NavController) {

  }

  Calculate() {
    this.HeightP2 = this.Height * this.Height;
    this.BMI = (this.Weight / this.HeightP2) * 703;

    if (this.BMI < 18.5) this.Result = "You're underweight. You should consult your doctor!";
    else if (this.BMI > 25) this.Result = "You're overweight. You should consult your doctor!";
    else this.Result = "You're within the normal weight range.";
  }
}
