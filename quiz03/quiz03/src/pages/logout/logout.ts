import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateNewGuessResult } from '../../Models/CreateNewGuessResult';
import { NavController } from 'ionic-angular';
import { HelloIonicPage } from '../hello-ionic/hello-ionic';
import { LoginPage } from '../login/login';

@Component({
  selector: 'logout',
  templateUrl: 'logout.html'
})
export class LogoutPage {

  constructor(public http: HttpClient, public navCtrl: NavController) {
    LoginPage.username = "";
    this.navCtrl.setRoot(LoginPage);
  }

}
