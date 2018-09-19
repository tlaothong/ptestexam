import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { item } from '../model/item';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  item: item;
  test: string;
  constructor(public navParams: NavParams,public http: HttpClient) {
    this.test =this.navParams.data.username ;

    this.http
        .get<item>("https://localhost:5001/api/Values/GetItem")
        .subscribe(it => {
            this.item=it;
            console.log(it)
        });
    }
  }


