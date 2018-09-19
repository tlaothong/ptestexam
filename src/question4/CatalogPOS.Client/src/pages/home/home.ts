import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { CatalogServiceProvider } from '../../providers/catalog-service/catalog-service';


@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})

export class HomePage {
  Products: any[] = [];
  SearchKey: any = {};
  SearchText: string;

  SearchOptions: { key: string, value: string }[] = [
    { key: "ชื่อสินค้า", value: "Name" },
    { key: "รหัสสินค้า", value: "SerialNumber" },
    { key: "ราคาสินค้า", value: "UnitPrice" },
  ];

  constructor(public navCtrl: NavController,
    private catalogService: CatalogServiceProvider,
    private navParams: NavParams) {

  }

  onSubmit(){
    this.catalogService.Search(this.SearchKey, this.SearchText).then(data => {
      this.Products = data;
    });
  }

  Buy(product: any)
  {

  }
}
