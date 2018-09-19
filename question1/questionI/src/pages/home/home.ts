import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { calculate } from '../../app/model';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  
  height: number;
  weight: number;
  result: calculate = new calculate;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }
  cal(){
    this.http.get<calculate>("http://localhost:5000/api/cal/cal/"+this.weight+"/"+this.height)
    .subscribe(data => {
    this.result = data;
    });
  }

}
