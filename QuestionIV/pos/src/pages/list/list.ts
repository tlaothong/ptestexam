import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { APP_ID_RANDOM_PROVIDER } from '@angular/core/src/application_tokens';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {
  products: Product[];
  serialnumber: string;

  order: Product[];
  total: number;

  constructor(
    public navCtrl: NavController,
    public http: HttpClient) {

    this.getProduct();
    this.getOrder();

    this.total = 0;
  }

  getProduct() {
    this.http.get("https://localhost:44339/api/QuestionIV/GetStoreProducts")
      .subscribe((data: Product[]) => {
        this.products = data
      },
        error => {
          // ERROR: Do something
        });
  }

  getOrder() {
    this.http.get("https://localhost:44339/api/QuestionIV/GetOrder")
      .subscribe((data: Order) => {
        this.order = data.orders,
          this.total = data.totalPrice
      },
        error => {
          // ERROR: Do something
        });
  }

  addOrder(item: Product) {
    this.http.get("https://localhost:44339/api/QuestionIV/AddOrder/" + item.serialNumber)
      .subscribe((data: Order) => {
        this.order = data.orders,
       this.total = data.totalPrice
      },
        error => {
          // ERROR: Do something
        });
  }

}

export class Product {
  public name: string;
  public serialNumber: string;
  public unitPrice: number;
}

export class Order {
  public orders: Product[];
  public totalPrice: number;
}

