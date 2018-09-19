import { Multiple } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  numberMulti : number;
  row :number;
  column : number;
  result : string[][];
  convertResult : number;

 

  constructor(public navCtrl: NavController) {
  
  }

  cal() {
    this.row = this.numberMulti;
    this.column = this.numberMulti;
    
    for (var i ; i <= this.row; i++)
    {
      for(var j ; j <= this.column;j++ ) {

        this.convertResult = i * j;
        this.result[i][j] = this.convertResult.toString();
        console.log(this.result);
      
      }
        
    }
  }

}