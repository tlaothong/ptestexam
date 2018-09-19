import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  winners: Player[];
  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  Start()
  {
    this.http.get<Player[]>("http://localhost:5000/api/lottery/PickWinner/").subscribe(
      it => {
          // SUCCESS: Do something          
          console.log(it);
          alert("Success");
          this.winners = it;
      }, 
      error => {
          // ERROR: Do something
          console.log(error);
          alert(error);                
      });
  }
}

export class Player {
  public luckynumber: number;
  public name: string;
}
