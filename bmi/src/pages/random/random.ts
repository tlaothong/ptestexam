import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';

/**
 * Generated class for the RandomPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-random',
  templateUrl: 'random.html',
})
export class RandomPage {
  myRand;
  mess : string;
  

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }
  ionViewDidEnter() {
    this.myRand=this.random();
   }
 
  random() {
    this.myRand = Math.floor(Math.random()*99)+1;
  }
  picknumber(){
    /* if (this.number == this.myRand) {
      this.mess = "You Win!" */
  
}

}
