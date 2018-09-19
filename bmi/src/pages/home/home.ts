import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  height: number;
  weight: number;
  result: number;
  mess: string;
  
  constructor(public navCtrl: NavController,private http: HttpClient) {
    
  }
  calculateBMI(){
    ///{money}/{price} 
    this.http.get("https://localhost:5001/api/Values/bmi/"+this.height+"/"+this.weight).subscribe(
      (it:number) => {
         this.result = it;

         if (this.result < 18.5) {
          this.mess = "Underweight"
        }
        if (this.result > 18.5 && this.result < 25) {
          this.mess = "Normal"
        }

        if (this.result > 25 && this.result < 30) {
          this.mess = "Overweight"
        }

        if (this.result > 30) {
          this.mess = "Obese"
        }
         
      },
      error => {
          // ERROR: Do something
      });
  }
  
  

}
