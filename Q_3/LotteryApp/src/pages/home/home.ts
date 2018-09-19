import { Player } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {


  NumberLot: number;
  user1: Player;
  user2: Player;
  user3: Player;
  user4: Player;
  user5: Player;
  user6: Player;
  user7: Player;
  user8: Player;
  user9: Player;
  user10: Player;
  user11: Player;
  user12: Player;
  user13: Player;
  user14: Player;
  user15: Player;
  user16: Player;
  user17: Player;
  user18: Player;
  user19: Player;
  user20: Player;
  ShowMessage: string;

  constructor(public navCtrl: NavController) {
    this.user1 = {
      name: "gun",
      LotteryNumber: 90

    }

    this.user2 = {
      name: "Mon",
      LotteryNumber: 14
    }
    this.user3 = {
      name: "Mick",
      LotteryNumber: 65
    }
    this.user4 = {
      name: "Toaw",
      LotteryNumber: 78
    }
    this.user5 = {
      name: "Nook",
      LotteryNumber: 46
    }
    this.user6 = {
      name: "Onto Jung",
      LotteryNumber: 78
    }
    this.user7 = {
      name: "kodcool",
      LotteryNumber: 34
    }
    this.user8 = {
      name: "Rose",
      LotteryNumber: 16
    }
    this.user9 = {
      name: "Mari",
      LotteryNumber: 56
    }
    this.user10 = {
      name: "Miw",
      LotteryNumber: 94
    }
    this.user11 = {
      name: "Mather",
      LotteryNumber: 1
    }
    this.user12 = {
      name: "Zoey",
      LotteryNumber: 5
    }
    this.user13 = {
      name: "Yasuo",
      LotteryNumber: 59
    }
    this.user14 = {
      name: "Jinx",
      LotteryNumber: 96
    }
    this.user15 = {
      name: "Mao",
      LotteryNumber: 55
    }
    this.user16 = {
      name: "Satagi",
      LotteryNumber: 60
    }
    this.user17 = {
      name: "Genji",
      LotteryNumber: 8
    }
    this.user18 = {
      name: "sato",
      LotteryNumber: 18
    }
    this.user19 = {
      name: "Aisen",
      LotteryNumber: 39
    }
    this.user20 = {
      name: "kurono",
      LotteryNumber: 51
    }


  }

  randomLot() {
    this.NumberLot = Math.floor(Math.random() * (99 - 0 + 1)) + 0;
    //  if(this.NumberLot == )
    // }

    if (this.NumberLot == this.user1.LotteryNumber) {
      this.ShowMessage = this.user1.name + " is Winner";
    }
    else if (this.NumberLot == this.user2.LotteryNumber) {
      this.ShowMessage = this.user2.name + " is Winner";
    }
    else if (this.NumberLot == this.user3.LotteryNumber) {
      this.ShowMessage = this.user3.name + " is Winner";
    }
    else if (this.NumberLot == this.user4.LotteryNumber) {
      this.ShowMessage = this.user4.name + " is Winner";
    }
    else if (this.NumberLot == this.user5.LotteryNumber) {
      this.ShowMessage = this.user5.name + " is Winner";
    }
    else if (this.NumberLot == this.user6.LotteryNumber) {
      this.ShowMessage = this.user6.name + " is Winner";
    }
    else if (this.NumberLot == this.user7.LotteryNumber) {
      this.ShowMessage = this.user7.name + " is Winner";
    }
    else if (this.NumberLot == this.user8.LotteryNumber) {
      this.ShowMessage = this.user8.name + " is Winner";
    }
    else if (this.NumberLot == this.user9.LotteryNumber) {
      this.ShowMessage = this.user9.name + " is Winner";
    }
    else if (this.NumberLot == this.user10.LotteryNumber) {
      this.ShowMessage = this.user10.name + " is Winner";
    }
    else if (this.NumberLot == this.user11.LotteryNumber) {
      this.ShowMessage = this.user11.name + " is Winner";
    }
    else if (this.NumberLot == this.user12.LotteryNumber) {
      this.ShowMessage = this.user12.name + " is Winner";
    }
    else if (this.NumberLot == this.user13.LotteryNumber) {
      this.ShowMessage = this.user13.name + " is Winner";
    }
    else if (this.NumberLot == this.user14.LotteryNumber) {
      this.ShowMessage = this.user14.name + " is Winner";
    }
    else if (this.NumberLot == this.user15.LotteryNumber) {
      this.ShowMessage = this.user15.name + " is Winner";
    }
    else if (this.NumberLot == this.user16.LotteryNumber) {
      this.ShowMessage = this.user16.name + " is Winner";
    }
    else if (this.NumberLot == this.user17.LotteryNumber) {
      this.ShowMessage = this.user17.name + " is Winner";
    }
    else if (this.NumberLot == this.user18.LotteryNumber) {
      this.ShowMessage = this.user18.name + " is Winner";
    }
    else if (this.NumberLot == this.user19.LotteryNumber) {
      this.ShowMessage = this.user19.name + " is Winner";
    }
    else if (this.NumberLot == this.user20.LotteryNumber) {
      this.ShowMessage = this.user20.name + " is Winner";
    }
    else {
      this.ShowMessage = "Nobody are winner";
    }

  }

}
