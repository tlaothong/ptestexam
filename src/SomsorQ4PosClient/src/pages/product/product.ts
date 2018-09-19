import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, AlertController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Product, GlobalVarible } from '../../app/models';
import { ProductcreatePage } from '../productcreate/productcreate';

@IonicPage()
@Component({
  selector: 'page-product',
  templateUrl: 'product.html',
})
export class ProductPage {

  Products: Product[];

  constructor(public navCtrl: NavController, public navParams: NavParams, private http: HttpClient, public alertCtrl: AlertController) {
  }

  Create() {
    this.navCtrl.push(ProductcreatePage);
  }

  Delete(id: string) {
    const confirm = this.alertCtrl.create({
      title: "Delete '" + this.Products.find(x => x.id == id).name + "' ?",
      buttons: [
        {
          text: 'Cancel',
          handler: () => {
            console.log('Disagree clicked');
          }
        },
        {
          text: 'Confirm',
          handler: () => {
            this.http.post(GlobalVarible.host + "/api/Product/Delete/" + id, {}, GlobalVarible.httpOptions)
              .subscribe(data => {
                this.ionViewDidEnter();
              });
          }
        }
      ]
    });
    confirm.present();
  }

  Mock() {
    this.http.get(GlobalVarible.host + "/api/Product/UseMockProducts")
      .subscribe(data => {
        this.ionViewDidEnter();
      });
  }

  Reset() {
    this.http.get(GlobalVarible.host + "/api/Product/Reset")
      .subscribe(data => {
        this.ionViewDidEnter();
      });
  }

  ionViewDidEnter() {
    this.http.get<Product[]>(GlobalVarible.host + "/api/Product/List")
      .subscribe(data => {
        this.Products = data;
      });
  }
}
