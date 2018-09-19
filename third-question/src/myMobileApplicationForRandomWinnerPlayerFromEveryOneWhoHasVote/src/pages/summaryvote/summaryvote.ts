import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { PlayersProvider } from '../../providers/players/players';

@IonicPage()
@Component({
  selector: 'page-summaryvote',
  templateUrl: 'summaryvote.html',
})
export class SummaryvotePage {
  model: any = [];
  constructor(public navCtrl: NavController, public navParams: NavParams, private playerSvc: PlayersProvider) {
    this.model = this.playerSvc.allplayer;
  }

  randomWinner() {
    if (this.model.length > 1) {
      let rand = Math.floor(Math.random() * this.model.length);
      let winnerNumber = this.model[rand].votenumber;
      var playerWons = this.model.filter(it => it.votenumber == winnerNumber);
      alert("Winner Number is: " + winnerNumber + "\nPlayer(s) won are: " + JSON.stringify(playerWons));
      this.playerSvc.allplayer = [];
      this.model = [];
    }
    else {
      alert("Can not random, At least Player must have 2")
    }
  }
}
