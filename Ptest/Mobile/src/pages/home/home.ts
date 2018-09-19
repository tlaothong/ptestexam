import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  weight: any = {};
  height: any = {};
  data: string;
  bmi: any = {};
  ibs: any = {};
  xxx: number;

  constructor(public navCtrl: NavController) {

  }

  result() {
    // var bmi = (weight / ((height / 100) * (height / 100)));
    // var bmi = ((weight * 2.20462262) / (ibs * ibs)) * 703;
    this.ibs = this.height * 0.393;
    this.xxx = ((this.weight*2.2)*703) / ((this.ibs) * (this.ibs))
    this.bmi = this.xxx.toFixed(2);
    if (this.bmi > 25)
    {
        this.data =  "You are somewhat overweight.";
    }
    else if (this.bmi < 18.5)
    {
      this.data = "You are somewhat underweight.";
    }
    else if (this.bmi > 18.5 && this.bmi < 25)
    {
      this.data = "Congratulations! You are within a healthy weight range.";
    }
    console.log(JSON.stringify( this.bmi));
  }

}
