import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  alertCtrl: any;

  constructor(public navCtrl: NavController, ) {

  }
  result() {
    let rand = Math.floor(Math.random() * 99) + 1;
    alert(rand);
    // alert.present();
    
  }

  // alert.(rand);
}

