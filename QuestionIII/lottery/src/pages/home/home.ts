import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  players :Player[];
  name :string;
  luckkynumber :number;
  winners :Player[];

  constructor(
    public navCtrl: NavController,
    public http: HttpClient) {

    this.getPlayer();
  }

  getPlayer(){
    this.http.get("https://localhost:44339/api/QuestionIII/GetPlayer")
    .subscribe((data : Player[]) => {        
          this.players = data
      }, 
      error => {
          // ERROR: Do something
      });

  }

  chooselotto(){
    let option = { "headers": { "Content-Type": "application/json" } };
    let model = {
        name : this.name,
        number : this.luckkynumber
    }; // model here
    this.http.post("https://localhost:44339/api/QuestionIII/AddPlayers", model, option)
      .subscribe((data:  Player[]) => {
          this.players = data
      }, error => {
        // If error
      });
  }

  getwinner(){
    this.http.get("https://localhost:44339/api/QuestionIII/GetWinner")
    .subscribe((data : Player[]) => {        
          this.winners = data
      }, 
      error => {
          // ERROR: Do something
      });
  }
}

export class Player {
  public number: number;
  public name: string;
}
