import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { AdditemPage } from '../additem/additem';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  items: any[];

  constructor(public navCtrl: NavController) {

  }
  additem(){
    this.navCtrl.push(AdditemPage);
  }

  // initializeItems() {
   
  // }
  // getItems(ev: any) {
  //   // Reset items back to all of the items
  //   this.initializeItems();

  //   // set val to the value of the searchbar
  //   const val = ev.target.value;

  //   // if the value is an empty string don't filter the items
  //   if (val && val.trim() != '') {
  //     this.items = this.items.filter((item) => {
  //       return (item.toLowerCase().indexOf(val.toLowerCase()) > -1);
  //     })
  //   }
  }

