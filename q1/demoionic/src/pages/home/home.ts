import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  mytext: string;
  mymessage : string;
  weight: string;
  height: string;

  constructor(public navCtrl: NavController,private httpClient: HttpClient) {
    this.weight = "1";
  }
  getBMI() {  
    this.httpClient.get("http://localhost:8000/api/values/calculate/"+this.weight+"/"+this.height)
      .subscribe((data: any) => {
        this.mytext = "Your BMI: "+data.bmi;
        this.mymessage = data.message;
        alert(data.bmi);
      }, error => {
        // If error
      });
}
}
