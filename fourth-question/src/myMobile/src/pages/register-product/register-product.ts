import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@IonicPage()
@Component({
  selector: 'page-register-product',
  templateUrl: 'register-product.html',
})
export class RegisterProductPage {

  model: any = {};
  constructor(public navCtrl: NavController, public navParams: NavParams, private httpClient: HttpClient) {
  }

  registerproduct() {
    let option = { "headers": { "Content-Type": "application/json" } };
    this.httpClient.post("https://localhost:5001/api/values/registerproduct", this.model, option)
      .subscribe((data: any) => {
        if (data) {
          this.navCtrl.popToRoot();
        }
        else {
          alert("Something was wrong");
        }
      }, error => {
        console.log("Register Error: " + JSON.stringify(error));
      });
  }
}
