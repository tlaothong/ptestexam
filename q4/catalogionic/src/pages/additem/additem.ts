import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Item } from '../../app/model';
import { HttpClient } from '@angular/common/http';
import { HomePage } from '../home/home';

/**
 * Generated class for the AdditemPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-additem',
  templateUrl: 'additem.html',
})
export class AdditemPage {
  item : Item = new Item("","","",0);
  constructor(public navCtrl: NavController, public navParams: NavParams,private httpClient: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AdditemPage');
  }
  onSubmit(){ 
    let option = { "headers": { "Content-Type": "application/json" } };
    this.httpClient.post("http://localhost:8000/api/catalog/AddItem",
    this.item,
      option).subscribe((result: any) => {        
        console.log(result);
      }, error => {
        console.log(error);
      });
      alert("Success");
      this.item = new Item("","","",0);
    }
  clear()
  {
    this.item = new Item("","","",0);
  }
}
