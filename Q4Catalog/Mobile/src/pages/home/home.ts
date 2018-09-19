import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
    productList:any = [];
  constructor(public navCtrl: NavController,private http: HttpClient) {
    
  }
  
  ionViewDidEnter() {
    this.http.get<any[]>("http://node19.codenvy.io:47107/api/Product/ListProduct")
      .subscribe((data) => {
         console.log("Complete");
        this.productList = data;
      },
        error => {
          alert("Error: " + error + "\nError message: " + error.message + "\nError result: " + error.error)
        });
  }
}
