import { GlobalVariable } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { BmiModel } from '../../app/models';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight : number;
  height : number;
  bmiM : BmiModel = new BmiModel;
  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  calBmi() {
    this.http.get<BmiModel>(GlobalVariable.host +  "api/Bmi/calculateBMI/" + this.weight + "/" + this.height )
    .subscribe(data => {
        this.bmiM = data;
    });
  }

}
