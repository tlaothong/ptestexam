import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { GlobalVarible } from '../../app/models';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight: number;
  height: number;
  bmi: any;
  textdetail: string;


  constructor(public navCtrl: NavController ,public http: HttpClient ) {

  }


  CalBMI(){
    
    this.http.get<string>(GlobalVarible.host + "api/Cal/CalculatorBMI/" + this.weight+"/"+this.height)
      .subscribe(data => {
       
        this.bmi = data;
        console.log(this.bmi);
        
      });

  }
}
