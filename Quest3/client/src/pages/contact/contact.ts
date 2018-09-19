import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { DataProvider, Picker } from '../../providers/data';

@Component({
  selector: 'page-contact',
  templateUrl: 'contact.html'
})
export class ContactPage {
  winner: Picker[] = [];
  message: string;
  constructor(public navCtrl: NavController, private svc: DataProvider) {

  }

  getWinner()
  {
    this.winner = [];
    var random = Math.floor(Math.random()*99)+1;
    
    var i: number;
    for(i = 0; i < this.svc.Username.length; i++)
    {
      if(this.svc.Username[i].PickNumber == random)
        this.winner.push(this.svc.Username[i]);
    }
    if(this.winner.length == 0)
    this.message = "no winner from pick number " + random;
    this.svc.Username = [];
  }
}
