import { Component } from '@angular/core';
import { NavController, AlertController } from 'ionic-angular';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  rand:any;
  showuser:any;
  name:string;
  number:number;
  constructor(public navCtrl: NavController,public alertCtrl:AlertController,public formBuilder: FormBuilder) {
  }

  clickRand(){
if(this.number != null && this.name != ""){
    this.rand = Math.floor(Math.random()*5)+1;
    if(this.rand == this.number){
      let alert = this.alertCtrl.create({
        title: 'ยินดีด้วยคุณ '+ this.name,
        subTitle: 'ดีใจด้วยคุณถูกรางวัล',
        buttons: ['OK']
      });
      alert.present();
    }else{
      let alert = this.alertCtrl.create({
        title: 'เสียใจด้วยคุณ ' + this.name,
        subTitle: 'คุณไม่ถูกรางวัล',
        buttons: ['OK']
      });
      alert.present();
    }

}else{
  let alert = this.alertCtrl.create({
    title: 'Error!!!',
    subTitle: 'กรุณากรอกให้ครบ',
    buttons: ['OK']
  });
  alert.present();
}
}

}
