import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight: number = 0;
  height: number = 0;
  bmi: number = 0;
  result: string;

  constructor(public navCtrl: NavController) {

  }

  bmical() { 
    this.bmi = 0
   
    if(this.weight <= 0 || this.height <=0)  
    { this.result = "input again "; 
      this.bmi = 0;
      return;
     }

    this.bmi = (this.weight / (this.height * this.height)) * 703;
    
    if(this.bmi < 18.5)  
    { this.result = "You're underweight. You should consult your doctor!"; }
    else if(this.bmi > 25)  
    { this.result = "You're overweight. You should consult your doctor!"; }
    else if(this.bmi >= 18.5 && this.bmi <= 25)  
    { this.result = "You're within the normal weight range." ; }
    else  { 
      this.result = "input again "; 
      this.bmi = 0;
      return;

    }
  }


}
