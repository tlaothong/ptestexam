import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { AddcatalogPage } from '../addcatalog/addcatalog';
import { CompuPage } from '../compu/compu';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {

  }

  addcatalog(){
    this.navCtrl.push(AddcatalogPage)
  }

  compu(){
    this.navCtrl.push(CompuPage)
  }
}
