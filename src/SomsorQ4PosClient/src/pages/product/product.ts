import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, AlertController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Product, GlobalVarible } from '../../app/models';

@IonicPage()
@Component({
  selector: 'page-product',
  templateUrl: 'product.html',
})
export class ProductPage {

  Products: Product[];

  constructor(public navCtrl: NavController, private http: HttpClient, public alertCtrl: AlertController, public navParams: NavParams) {
  }

  Delete(id: string){
    console.log(id);
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

  ionViewDidEnter() {
    this.http.get<Product[]>(GlobalVarible.host + "/api/Product/List")
      .subscribe(data => {
        this.Products = data;
      });
  }
}
