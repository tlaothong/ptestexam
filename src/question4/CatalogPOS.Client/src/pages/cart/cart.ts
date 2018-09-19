import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';

/**
 * Generated class for the CartPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-cart',
  templateUrl: 'cart.html',
})
export class CartPage {
  Product: any;
  Amount: number;
  Price: number = 0.0;
  constructor(public navCtrl: NavController, public navParams: NavParams) {
    this.Product = navParams.data;
    console.log(this.Product);
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CartPage');
  }

  Calculate()
  {
    this.Price = this.Product.UnitPrice * this.Amount;
  }

}
