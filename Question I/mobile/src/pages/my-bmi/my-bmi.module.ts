import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { MyBmiPage } from './my-bmi';

@NgModule({
  declarations: [
    MyBmiPage,
  ],
  imports: [
    IonicPageModule.forChild(MyBmiPage),
  ],
})
export class MyBmiPageModule {}
