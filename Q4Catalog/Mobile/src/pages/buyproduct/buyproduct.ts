import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the BuyproductPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-buyproduct',
  templateUrl: 'buyproduct.html',
})
export class BuyproductPage {
   productList:product[] = [];
  
  taotalPrice:number;
  constructor(public navCtrl: NavController, public navParams: NavParams,private http: HttpClient) {
      this.taotalPrice = 0;
  }

  ionViewDidEnter() {
    this.http.get<product[]>("http://node17.codenvy.io:55659/api/Product/ListProduct")
      .subscribe((data) => {
         console.log("Complete");
        this.productList = data;
      },
        error => {
          alert("Error: " + error + "\nError message: " + error.message + "\nError result: " + error.error)
        });
  }
    
add(item:any)
{
    this.taotalPrice += item.unitPrice;
    if(item.qun >= 1)
    {
            item.qun += 1;
    }
    else {  item.qun = 1;}
}
}
export class product
{
    _id:string;
    name:string;
    serialNumber:string;
    unitPrice:number;
    qun:number;
}
