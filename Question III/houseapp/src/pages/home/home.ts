import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  winners: Player[];
  winnernumber: number;
  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  Start()
  {
    this.winners = null;
    this.winnernumber = null;
    this.http.get<Player[]>("http://localhost:5000/api/lottery/PickWinner/").subscribe(
      it => {
          // SUCCESS: Do something          
          console.log(it);
          this.winners = it;
          this.winnernumber = it[0].luckyNumber;
      }, 
      error => {
          // ERROR: Do something
          console.log(error);
          alert("Some player not guess the number yet");                
      });

  }
}

export class Player {
  public luckynumber: number;
  public name: string;
}
