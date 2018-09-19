import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  n : number;
  table : number[][] = [];

  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  GetTable() {
    this.http.get<number[][]>("https://localhost:5001/api/Values/GetTable/" + this.n)
      .subscribe(data => {
        this.table = data;        
      });
  }




}
