import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { ProductInfo } from '../../models/productInfo';
import { SelectedProductInfo } from '../../models/selectedProductInfo';
import { PurchaseOrderPage } from '../purchaseOrder/purchaseOrder';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  products: ProductInfo[];
  selectedProducts: SelectedProductInfo[] = [];
  totalPrice: string;
  canSendAnOrder: boolean = false;

  newProductName: string;
  newProductPrice: number = 0;

  constructor(public navCtrl: NavController, public http: HttpClient) {
  }

  ionViewDidLoad() {
    this.reloadProducts();
  }

  createNewProduct() {
    this.http.post<ProductInfo>("http://localhost:5000/api/POS",
      {
        "name": this.newProductName,
        "price": this.newProductPrice,
        "customTags": "string"
      }).subscribe(
        it => {
          this.newProductName = "";
          this.newProductPrice = 0;
          this.reloadProducts();
        });
  }

  reloadProducts() {
    this.http.get<ProductInfo[]>("http://localhost:5000/api/POS").subscribe(
      it => {
        this.products = it;
      });
  }

  selectProduct(it: ProductInfo) {
    var selectedProduct = this.selectedProducts.filter(x => x.product.id == it.id);
    for (let element of selectedProduct) {
      var index = this.selectedProducts.indexOf(element);
      if (index > -1) {
        return;
      }
    }

    var selected = new SelectedProductInfo();
    selected.product = it;
    selected.quantities = 1;
    this.selectedProducts.push(selected);
    this.updateTotalPrice();
  }


  remove(it: SelectedProductInfo) {
    var selectedProduct = this.selectedProducts.filter(x => x.product.id == it.product.id);
    selectedProduct.forEach(element => {
      var index = this.selectedProducts.indexOf(element);
      if (index > -1) {
        this.selectedProducts.splice(index, 1);
      }
    });
    this.updateTotalPrice();
  }

  update(it: SelectedProductInfo, isIncreasing: boolean) {
    var selectedProduct = this.selectedProducts.filter(x => x.product.id == it.product.id);
    for (let element of selectedProduct) {
      var index = this.selectedProducts.indexOf(element);
      if (index > -1) {
        if (isIncreasing) it.quantities++;
        else it.quantities--;
        if (it.quantities <= 0) this.selectedProducts.splice(index, 1);
      }
    }
    this.updateTotalPrice();
  }

  updateTotalPrice() {
    this.validateSendAnOrder();
    var priceSummation = 0;
    for (let element of this.selectedProducts) {
      priceSummation += element.product.price * element.quantities;
    }
    if (priceSummation > 0) this.totalPrice = "Total price: " + priceSummation;
    else this.totalPrice = "";
  }

  purchaseOrder() {
    this.navCtrl.push(PurchaseOrderPage, {
      data: this.selectedProducts
    })
  }

  validateSendAnOrder() {
    this.canSendAnOrder = this.selectedProducts.length > 0;
  }

}
