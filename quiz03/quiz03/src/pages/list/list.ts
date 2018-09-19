import { Component } from '@angular/core';

import { NavController, NavParams } from 'ionic-angular';

import { ItemDetailsPage } from '../item-details/item-details';
import { HttpClient } from '@angular/common/http';
import { CloseGuessVoteResult } from '../../Models/CloseGuessVoteResult';
import { LoginPage } from '../login/login';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {

  name: string;
  message: string;
  isSubmited: boolean;
  winners: CloseGuessVoteResult = new CloseGuessVoteResult();
  anyWinner: boolean = true;

  constructor(public http: HttpClient, public navCtrl: NavController) {
    if (LoginPage.username == undefined || LoginPage.username == "") {
      this.navCtrl.setRoot(LoginPage);
      return;
    }
    this.name = LoginPage.username;
  }

  submitClose() {
    this.isSubmited = true;
    this.http.post<CloseGuessVoteResult>("https://localhost:5001/api/Lottery/close",
      {
        "username": LoginPage.username
      }).subscribe(
        it => {
          if (it.errorMessage == null) {
            this.winners = it;
            this.anyWinner = this.winners.winnerNames.length > 0;
          }
          else this.message = it.errorMessage;
        });
  }

}
