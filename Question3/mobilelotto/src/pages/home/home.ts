import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
 result: number;
  constructor(public navCtrl: NavController) {

  }
 


  randomLotto(){
    
 this.result= Math.floor(Math.random() * ((99 - 0) + 1)) + 0
 
  }
  

}
