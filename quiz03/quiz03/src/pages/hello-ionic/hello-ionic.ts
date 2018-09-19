import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateNewGuessResult } from '../../Models/CreateNewGuessResult';
import { LoginPage } from '../login/login';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-hello-ionic',
  templateUrl: 'hello-ionic.html'
})
export class HelloIonicPage {

  name: string;
  guessNo: number = 0;
  message: string;
  isSubmited: boolean;

  constructor(public http: HttpClient, public navCtrl: NavController) {
    if (LoginPage.username == undefined || LoginPage.username == "") {
      this.navCtrl.setRoot(LoginPage);
      return;
    }
    this.name = LoginPage.username;
  }

  SubmitGuess() {
    if (LoginPage.username == undefined || LoginPage.username == "") {
      this.message = "Please input your name before submit!";
      return;
    }

    this.isSubmited = true;
    this.http.post<CreateNewGuessResult>("https://localhost:5001/api/Lottery",
      {
        "name": LoginPage.username,
        "guessNo": this.guessNo
      }).subscribe(
        it => {
          if (it.errorMessage == null) {
            this.message = "Complete";
          }
          else {
            this.isSubmited = false;
            this.message = it.errorMessage;
          }
        });
  }

}
