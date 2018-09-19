import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  name : string;
  num : number;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }
  rand() {
    this.http.get("https://localhost:5001/api/Values/"+this.name + "/" + this.num)
      .subscribe(
        data => {
          // SUCCESS: Do something
        });
  }
}
