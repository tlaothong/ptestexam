import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { GuessnumberPage } from './guessnumber';

@NgModule({
  declarations: [
    GuessnumberPage,
  ],
  imports: [
    IonicPageModule.forChild(GuessnumberPage),
  ],
})
export class GuessnumberPageModule {}
