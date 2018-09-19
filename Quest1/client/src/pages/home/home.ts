import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  weight: number = 0;
  height: number = 0;
  message: string;
  constructor(public navCtrl: NavController, private http: HttpClient) {

  }

  getBMI()
  {
    return this.http.get('https://localhost:5001/api/bmi/Calculator/' + this.weight + "/" + this.height, {responseType: 'text'}).subscribe(
      (data) => {this.message = data;}, (er) => {this.message = er.message;}
    );
  }
}
