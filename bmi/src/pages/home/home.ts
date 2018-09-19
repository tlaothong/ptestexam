import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { style } from '../../../node_modules/@angular/core/src/animation/dsl';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  weight:any;
  height:any;
  answer:any;
  met:any;
  detail:string;
  constructor(public navCtrl: NavController) {
      this.answer = "0.00";
  }
  checkBMI(){
    this.met = this.height/100;
    this.answer = (this.weight/(this.met*this.met)).toFixed(2);
    if(this.answer >= 18.5 && this.answer <= 25){
      this.detail = "You're within the normal weight range.";
    }else if(this.answer < 18.5){
      this.detail = "You're underweight. You should consult your doctor!";
    }else if(this.answer > 25){
      this.detail = "You're overweight. You should consult your doctor!";
    }
  }

}
