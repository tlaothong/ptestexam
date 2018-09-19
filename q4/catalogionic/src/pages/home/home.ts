import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Item } from '../../app/model';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  items: Item[];
  constructor(public navCtrl: NavController,private httpClient: HttpClient) {

  }
  ionViewWillEnter(){
    this.httpClient.get("http://localhost:8000/api/catalog/GetCatalogs")
    .subscribe((data: any) => {
      this.items = data;
      //alert(JSON.stringify(data));
    }, error => {
      // If error
    });
  }
}
