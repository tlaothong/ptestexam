import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { CatalogServiceProvider } from '../../providers/catalog-service/catalog-service';

/**
 * Generated class for the AddProductPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-add-product',
  templateUrl: 'add-product.html',
})
export class AddProductPage {

  Product: {Name: string, SerialNumber: string, UnitPrice: number} = {Name: "", SerialNumber: "", UnitPrice: 0.0};

  constructor(public navCtrl: NavController, public navParams: NavParams, private catalogService: CatalogServiceProvider) {
  }

  ionViewDidEnter() {
    console.log('ionViewDidLoad AddProductPage');
  }

  onSubmit()
  {
    this.catalogService.AddProduct(this.Product)
    .then(() => this.navCtrl.pop());
  }
}
