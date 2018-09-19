import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Dog } from '../../app/models';
/**
 * Generated class for the AddPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-add',
  templateUrl: 'add.html',
})
export class AddPage {
  item : Dog;
  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
    this.item = new Dog();
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AddPage');
  }

  goHomePage() {
    console.log(this.item);
    this.http.post<Dog>("http://localhost:5000/api/Values/create", {
      "id": this.item.id,
      "Name":this.item.Name,
      "Serial":this.item.Serial,
      "price":this.item.Price
    })
      .subscribe(it => {
        // SUCCESS: Do something
      },
        error => {
          // ERROR: Do something
        });
        
    this.navCtrl.pop();
  }

}
