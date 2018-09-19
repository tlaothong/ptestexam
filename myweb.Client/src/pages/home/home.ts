import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

import { AlertController } from 'ionic-angular';
import { CalBmipagePage } from '../cal-bmipage/cal-bmipage';
import { CatepagePage } from '../catepage/catepage';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  lottary = [];
  winner = [];
  numberLottary: number;
  username: String;
  number: number;
  constructor(public navCtrl: NavController, private alertCtrl: AlertController) {
    this.numberLottary = 0;
 

  }
  cannotAddAlert() {
    const alert = this.alertCtrl.create({
      title: 'ไม่สามารถเพิ่มหมายเลขได้!',
      subTitle: 'มีคนใช้ชื่อนี้แล้ว',
      buttons: ['OK']
    });
    alert.present();
  }


  AddLottary() {

    if (this.lottary.length == 0 || this.lottary == null) {
      this.lottary.push({
        id: this.lottary.length,
        username: this.username,
        number: this.number
      });

    } else {
      let data = this.lottary.find(x => x.username == this.username);
      console.log(data)
      if (data == undefined) {
        this.lottary.push({
          id: this.lottary.length,
          username: this.username,
          number: this.number
        });
      }else{
        this.cannotAddAlert();
      }
    }
    this.username = "";
    this.number = 0;
    console.log(this.lottary)
  }

  Start() {
    this.numberLottary = Math.floor(Math.random() * 99) + 0;
    for (var i = 0; i < this.lottary.length; i++) {

      if (this.lottary[i].number == this.numberLottary) {
        this.winner.push({
          id: this.winner.length,
          username: this.lottary[i].username,
          number: this.lottary[i].number
        });

      }

    }
    console.log(this.winner)
  }

  goBmi(){
    this.navCtrl.push(CalBmipagePage);
  }
  goCate(){
    this.navCtrl.push(CatepagePage);
  }

}
