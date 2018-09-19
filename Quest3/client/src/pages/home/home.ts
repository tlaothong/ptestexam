import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { DataProvider, Picker } from '../../providers/data';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  Username: string;
  Pick: number;
  message: string;
  colorMessage: string = "primary";
  constructor(public navCtrl: NavController, public svc: DataProvider) {

  }

  savePick()
  {
    if(this.havePick(this.Username)){
      this.colorMessage = "danger";
      this.message = this.Username + " already picked some number.";
      return;
    }
    if(this.Pick >= 0 && this.Pick <= 99 ){
      this.colorMessage = "primary";
    this.svc.Username.push(new Picker(this.Username, +this.Pick));
    this.message = this.Username + " pick number " + (+this.Pick) + " have saved.";
    }
    else{
      this.colorMessage = "danger";
      this.message = "Pick Number 0 - 99."
    }
  }

  havePick(username: string)
  {
    var alreadyPick = false;
    var i: number;
    for(i = 0; i < this.svc.Username.length; i++)
    {
      if(this.svc.Username[i].Username == username)
        alreadyPick = true;
    }
    return alreadyPick;
  }
}
