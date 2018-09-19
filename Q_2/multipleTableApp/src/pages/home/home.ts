import { Multiple } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  numberMulti : number;
  N_row :number;
  N_column : number;
  result : string[][];
  convertResult : number;

 

  constructor(public navCtrl: NavController) {
  
  }

  calculate() {
    this.N_row = this.numberMulti;
    this.N_column = this.numberMulti;
    
    for (var i ; i <= this.N_row; i++)
    {
      for(var j ; j <= this.N_column;j++ ) {

        this.convertResult = i * j;
        this.result[i][j] = this.convertResult.toString();
        console.log(this.result);
      
      }
        
    }
  }

}
