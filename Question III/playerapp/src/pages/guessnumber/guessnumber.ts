import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the GuessnumberPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-guessnumber',
  templateUrl: 'guessnumber.html',
})
export class GuessnumberPage {

  name: string;
  guessnumber: number;

  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
    this.name = navParams.get('name');
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad GuessnumberPage');
  }

  GuessNumber()
  {
    this.http.post<string>("http://localhost:5000/api/lottery/guessnumber/",
    {
      Name : this.name,
      LuckyNumber : this.guessnumber
    }).subscribe(
    it => {
        // SUCCESS: Do something    
        
        console.log(it);
    }, 
    error => {
        // ERROR: Do something
        console.log(error);
        alert(error);                
    });
  }
}
