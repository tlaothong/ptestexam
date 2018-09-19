import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { AddcatalogPage } from './addcatalog';

@NgModule({
  declarations: [
    AddcatalogPage,
  ],
  imports: [
    IonicPageModule.forChild(AddcatalogPage),
  ],
})
export class AddcatalogPageModule {}
