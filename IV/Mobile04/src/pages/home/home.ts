import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { AddPage } from '../add/add';
import { HttpClient } from '@angular/common/http';
import { Dog } from '../../app/models';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  item :Dog;
  constructor(public navCtrl: NavController, public http: HttpClient) {
    // this.item = new Dog();
    this.http.get<Dog>("http://localhost:5000/api/Values/GetAllDog").subscribe(
      it => {
        this.item = new Dog();
        this.item = it;
          // SUCCESS: Do something
      }, 
      error => {
          // ERROR: Do something
      });
  }

  goAddPage(){
    this.navCtrl.push(AddPage);
  }

}
