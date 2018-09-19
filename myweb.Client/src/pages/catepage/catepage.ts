import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { ProductGet } from '../../app/models';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the CatepagePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-catepage',
  templateUrl: 'catepage.html',
})
export class CatepagePage {
  catedata: ProductGet[];
  cate: ProductGet = new ProductGet;
  showProductArr = [];
  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {


    this.cate.price = 0;
  }
  ionViewWillEnter() {
    this.http.get<ProductGet[]>("https://localhost:5001/api/Pretestexam/GetProducts").subscribe(data => {
      this.catedata = data;
    

    });
  }
  ionViewDidLoad() {
    console.log('ionViewDidLoad CatepagePage');
  }

  addProduct() {

    this.cate.name = "";
    this.cate.snumber = "";
    this.cate.price = 0;
  }

}
