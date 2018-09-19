import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { BmiServiceProvider } from '../../providers/bmi-service/bmi-service';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight: number;
  height: number;
  bmi: number;
  suggest: string;
  constructor(public navCtrl: NavController, private BMIService: BmiServiceProvider) {

  }

  Calculate()
  {
    this.BMIService.Calculate(this.weight, this.height).then(data => {
      this.bmi = data.bmi;
      this.suggest = data.suggestMessage;
    });
  }
}
