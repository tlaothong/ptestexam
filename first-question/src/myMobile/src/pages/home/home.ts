import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  model: any = {};
  constructor(public navCtrl: NavController) {

  }

  calculate() {
    var bmi = (this.model.weight / Math.pow(this.model.height, 2)) * 703;
    var message = "";
    if (bmi < 18.5) message = "You're underweight. You should consult your doctor!";
    else if (bmi < 25) message = "You're within the normal weight range.";
    else message = "otherwise suggest to consult the doctor."
    alert("Your BMI: " + bmi + "\n" + message);
  }

}
