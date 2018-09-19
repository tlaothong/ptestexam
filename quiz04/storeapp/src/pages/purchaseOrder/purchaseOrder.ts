import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { ProductInfo } from '../../models/productInfo';
import { SelectedProductInfo } from '../../models/selectedProductInfo';
import { PurchaseOrderInfo } from '../../models/purchaseOrderInfo';
import { PurchaseOrderResponse } from '../../models/purchaseOrderResponse';

@Component({
  selector: 'purchaseOrder',
  templateUrl: 'purchaseOrder.html'
})
export class PurchaseOrderPage {

  selectedProducts: SelectedProductInfo[] = [];
  totalPrice: string;
  isAlreadySendAnOder: boolean;
  products: PurchaseOrderInfo[] = [];
  message: string;

  constructor(public navCtrl: NavController, public http: HttpClient, public navParams: NavParams) {
    this.selectedProducts = navParams.get('data');
    for (let element of this.selectedProducts) {
      var data = new PurchaseOrderInfo();
      data.id = element.product.id;
      data.quantities = element.quantities;
      this.products.push(data);
    }
    this.updateTotalPrice();
  }

  updateTotalPrice() {
    var priceSummation = 0;
    for (let element of this.selectedProducts) {
      priceSummation += element.product.price * element.quantities;
    }
    if (priceSummation > 0) this.totalPrice = "Total price: " + priceSummation;
    else this.totalPrice = "";
  }

  purchaseOrder() {
    if (this.isAlreadySendAnOder) return;

    this.http.post<PurchaseOrderResponse>("http://localhost:5001/api/POS/purchaseorder",
      {
        orders: JSON.stringify(this.products),
      }).subscribe(
        it => {
          console.log(it)
          this.message = "Completed";
        }, err => {
          console.log(err);
        });
  }

}
