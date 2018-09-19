import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateNewGuessResult } from '../../Models/CreateNewGuessResult';
import { NavController } from 'ionic-angular';
import { HelloIonicPage } from '../hello-ionic/hello-ionic';

@Component({
  selector: 'login',
  templateUrl: 'login.html'
})
export class LoginPage {

  inputUsername: string;
  public static username: string;
  message: string;

  constructor(public http: HttpClient, public navCtrl: NavController) {
  }

  login() {
    if (this.inputUsername == undefined && this.inputUsername == "") {
      this.message = "Please insert your username!";
      return;
    }

    LoginPage.username = this.inputUsername;
    this.navCtrl.setRoot(HelloIonicPage);
  }

}
