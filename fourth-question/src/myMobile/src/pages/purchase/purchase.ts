import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@IonicPage()
@Component({
  selector: 'page-purchase',
  templateUrl: 'purchase.html',
})
export class PurchasePage {

  search: string;
  quantity: string;

  model: any = [];
  totalprice: number = 0;

  constructor(public navCtrl: NavController, public navParams: NavParams, private httpClient: HttpClient) {
  }

  searchproduct() {
    this.httpClient.get("https://localhost:5001/api/Values/CalculateTotalPrice/" + this.search + "/" + this.quantity)
      .subscribe((data: any) => {
        if (data.productDetail == null) alert("Product is not found");
        else {
          this.model.push(data);
          this.totalprice += data.totalPrice;
        }
      }, error => {
        console.log("Purchase Error: " + JSON.stringify(error));
      });
  }
}
