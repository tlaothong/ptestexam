import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NavController, ActionSheetController, AlertController } from 'ionic-angular';
import { Item, GlobalVarible } from '../../app/models';
import { ItemEditPage } from '../item-edit/item-edit';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  items: Item[];
  click: boolean = false;
  item: Item;

  constructor(public navCtrl: NavController, public http: HttpClient, public actionSheetCtrl: ActionSheetController, public alertCtrl: AlertController) {

  }

  ionViewDidEnter() {
    this.item = new Item;
    this.http.get<Item[]>(GlobalVarible.host + "/api/Catalog/ListItems")
      .subscribe(data => {
        this.items = data;
      });
  }

  AddItem() {
    this.click = false;
    this.http.post(GlobalVarible.host + "/api/Catalog/CreateItem", this.item)
      .subscribe(data => {
        this.ionViewDidEnter();
      });
  }

  Click() {
    this.click = true;
  }

  Cancel() {
    this.click = false;
  }

  press(item: Item) {

    const actionSheet = this.actionSheetCtrl.create({
      buttons: [
        {
          text: 'Edit',
          icon: 'build',
          handler: () => {
            console.log('Destructive clicked');
            this.navCtrl.push(ItemEditPage, { _id: item.id });

          }
        }, {
          text: 'Delete',
          icon: 'trash',
          handler: () => {

            const confirm = this.alertCtrl.create({
              title: 'Delete ' + item.name + ' ?',
              buttons: [
                {
                  text: 'Cancel',
                  handler: () => {
                    console.log('Disagree clicked');
                  }
                },
                {
                  text: 'Confirm',
                  handler: () => {
                    console.log('Agree clicked');
                    this.http.post(GlobalVarible.host + "/api/Lender/DeleteItem/" + item.id, {})
                      .subscribe(data => {
                        this.ionViewDidEnter()
                      });
                  }
                }
              ]
            });
            confirm.present();
          }
        },
      ]
    });
    actionSheet.present();
  }
}
