import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  input1: number;
  input2: number;
  result: number;

  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  calculate()
  {
  this.http
    .get<number>("http://localhost:5000/api/bmicalculate/"+this.input1+"/"+this.input2)
    .subscribe(it =>{
        this.result = it;
     
    });
  }

}
