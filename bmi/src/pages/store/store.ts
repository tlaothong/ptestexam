import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the StorePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-store',
  templateUrl: 'store.html',
})
export class StorePage {
  name: string;
  number: string;
  price: string;
  sum: string;

  constructor(public navCtrl: NavController, public navParams: NavParams,private http: HttpClient) {
  }
  insert(){
    ///{money}/{price} 
    this.http.get("https://localhost:5001/api/Values/bmi/"+this.name+"/"+this.number+"/"+this.price).subscribe(
      (it:string) => {
         this.sum = it;
         console.log(this.sum);

        
         
      },
      error => {
          // ERROR: Do something
      });
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad StorePage');
  }

}
