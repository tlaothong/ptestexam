import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight:number;
  hight:number;
  result:number;
  bmi1:string;
  bmi2:string;
  constructor(public navCtrl: NavController) {

  }
  Calculate()
  {  
    
      this.result =  this.weight /(this.hight*this.hight)*703
      if(this.result >=18.5)
            {
              this.bmi1 = "You're within the normal weight range."
              return this.result + this.bmi1;
            }
       if(this.result<18.5)
            {
              this.bmi1 = "You're underweight. You should consult your doctor!"
               return this.result+this.bmi2;
                
            }
  }

}
