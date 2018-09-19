import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateNewGuessResult } from '../../Models/CreateNewGuessResult';

@Component({
  selector: 'page-hello-ionic',
  templateUrl: 'hello-ionic.html'
})
export class HelloIonicPage {

  name: string;
  guessNo: number = 0;
  message: string;
  isSubmited: boolean;

  constructor(public http: HttpClient) {
  }

  SubmitGuess() {
    if (this.name == undefined || this.name == "") {
      this.message = "Please input your name before submit!";
      return;
    }

    this.isSubmited = true;
    this.http.post<CreateNewGuessResult>("https://localhost:5001/api/Lottery",
      {
        "name": this.name,
        "guessNo": this.guessNo
      }).subscribe(
        it => {
          if (it.errorMessage == null) {
            this.message = "Complete";
          }
          else this.message = it.errorMessage;
        });
  }

}
