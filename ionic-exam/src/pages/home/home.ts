import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { CatalogPage } from '../catalog/catalog';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  Weight: number;
  Height: number;
  result: number;
  BMI: string;
  str: string

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }

  Catalog(){
    this.navCtrl.push(CatalogPage)
  }

  calculate() {
    this.http.get<number>("https://localhost:5001/api/Values/calculatingbmi/" + this.Weight + "/" + this.Height)
      .subscribe(data => {
        this.result = data;


        if (this.result >= 18.5 && this.result <= 25) {
          this.BMI = "BMI ของคุณ : ";
          this.str = "คุณอยู่ในช่วงน้ำหนักปกติ";
        }

        else if (this.result < 18.5) {
          this.BMI = "BMI ของคุณ : ";
          this.str = "คุณน้ำหนักน้อย คุณควรปรึกษาแพทย์ !";
        }
      });
  }

}

