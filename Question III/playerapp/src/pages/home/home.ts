import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { GuessnumberPage } from '../guessnumber/guessnumber';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  name: string;

  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad MyBmiPage');
  }

  RegisterName()
  {
    if((!this.name || this.name == undefined || this.name == "" || this.name.length == 0))
    { alert("Please input your name") }
    else{
    this.http.post<string>("http://localhost:5000/api/lottery/register/",
      {
        Name : this.name,
      }).subscribe(
      it => {
          // SUCCESS: Do something          
          console.log(it);
          this.navCtrl.push(GuessnumberPage, { name: this.name });
      }, 
      error => {
          // ERROR: Do something
          console.log(error);
          alert("Duplicate name!");                
      });

    }
  }
}
