import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

import { SummaryvotePage } from '../summaryvote/summaryvote';
import { PlayersProvider } from '../../providers/players/players';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  model: any = {};
  constructor(public navCtrl: NavController, private playerSvc: PlayersProvider) {
  }

  viewsummary() {
    this.navCtrl.push(SummaryvotePage);
  }

  submit() {
    this.playerSvc.allplayer.push(this.model);
    this.model = {};
    this.navCtrl.push(SummaryvotePage);
  }

}
