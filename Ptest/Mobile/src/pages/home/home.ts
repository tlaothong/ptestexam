import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  weight: any={};
  height: any={};
  data: string;
  bmi: any;


  constructor(public navCtrl: NavController) {

  }

  result(){
    // var bmi = (weight / ((height / 100) * (height / 100)));
 var xxx = (this.weight/((this.height/100)*(this.height/100)))
 if(xxx>=30){
this.data = "Obese 3";
 }else if(xxx>=25 && xxx>30){
  this.data = "Obese 2";
 }else if(xxx>=23 && xxx>25){
  this.data = "Obese 1";
 }else if(xxx>=18.5 && xxx>23){
  this.data = "Normal weight";
 }else {
  this.data = "Underweight";
 }
 this.bmi = xxx.toFixed(2);
 console.log(xxx);
  }

}
