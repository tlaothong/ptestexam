import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { userPlayer } from '../../app/model';


@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  num: number;
  user1: userPlayer;
  user2: userPlayer;
  user3: userPlayer;
  user4: userPlayer;
  user5: userPlayer;
  user6: userPlayer;
  user7: userPlayer;
  user8: userPlayer;
  user9: userPlayer;
  user10: userPlayer;
  user11: userPlayer;
  user12: userPlayer;
  user13: userPlayer;
  user14: userPlayer;
  user15: userPlayer;
  showWinner: string;

  constructor(public navCtrl: NavController) {
    this.user1 = {
      name: "mick0",
      numberOfWinner: 10
    }
    this.user2 = {
      name: "mick1",
      numberOfWinner: 12
    }
    this.user3 = {
      name: "mick2",
      numberOfWinner: 22
    }
    this.user4 = {
      name: "mick3",
      numberOfWinner: 31
    }
    this.user5 = {
      name: "mick4",
      numberOfWinner: 17
    }
    this.user6 = {
      name: "mick5",
      numberOfWinner: 17
    }
    this.user7 = {
      name: "mick6",
      numberOfWinner: 17
    }
    this.user8 = {
      name: "mick7",
      numberOfWinner: 26
    }
    this.user9 = {
      name: "mick8",
      numberOfWinner: 33
    }
    this.user10 = {
      name: "mick9",
      numberOfWinner: 47
    }
    this.user11 = {
      name: "mick10",
      numberOfWinner: 54
    }
    this.user12 = {
      name: "mick11",
      numberOfWinner: 62
    }
    this.user13 = {
      name: "mick12",
      numberOfWinner: 78
    }
    this.user14 = {
      name: "mick13",
      numberOfWinner: 84
    }
    this.user15 = {
      name: "mick14",
      numberOfWinner: 99
    }
  }

  random() {

    this.num = Math.floor(Math.random() * ((99 - 0) + 1)) + 0;

    if (this.num == this.user1.numberOfWinner) {
      this.showWinner = this.user1.name + " is the winner.";
    }

    else if (this.num == this.user2.numberOfWinner) {
      this.showWinner = this.user2.name + " is the winner.";
    }
    else if (this.num == this.user3.numberOfWinner) {
      this.showWinner = this.user3.name + " is the winner.";
    }
    else if (this.num == this.user4.numberOfWinner) {
      this.showWinner = this.user4.name + " is the winner.";
    }
    else if (this.num == this.user5.numberOfWinner) {
      this.showWinner = this.user5.name + " is the winner.";
    }
    else if (this.num == this.user6.numberOfWinner) {
      this.showWinner = this.user6.name + " is the winner.";
    }
    else if (this.num == this.user7.numberOfWinner) {
      this.showWinner = this.user7.name + " is the winner.";
    }
    else if (this.num == this.user8.numberOfWinner) {
      this.showWinner = this.user8.name + " is the winner.";
    }
    else if (this.num == this.user9.numberOfWinner) {
      this.showWinner = this.user9.name + " is the winner.";
    }
    else if (this.num == this.user10.numberOfWinner) {
      this.showWinner = this.user10.name + " is the winner.";
    }
    else if (this.num == this.user11.numberOfWinner) {
      this.showWinner = this.user11.name + " is the winner.";
    }
    else if (this.num == this.user12.numberOfWinner) {
      this.showWinner = this.user12.name + " is the winner.";
    }
    else if (this.num == this.user13.numberOfWinner) {
      this.showWinner = this.user13.name + " is the winner.";
    }
    else if (this.num == this.user14.numberOfWinner) {
      this.showWinner = this.user14.name + " is the winner.";
    }
    else if (this.num == this.user15.numberOfWinner) {
      this.showWinner = this.user15.name + " is the winner.";
    }
    else {
      "There hasn't the winner.";
    }

  }

}
