import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SummaryvotePage } from './summaryvote';

@NgModule({
  declarations: [
    SummaryvotePage,
  ],
  imports: [
    IonicPageModule.forChild(SummaryvotePage),
  ],
})
export class SummaryvotePageModule {}
