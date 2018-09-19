import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  name:string;
  number:string;

  constructor(public navCtrl: NavController) {

  }

  Start(){
    
  }
}
