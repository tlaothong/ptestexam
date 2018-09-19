import { User } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  users: User[] = new Array<User>(100);
  user: User = new User;
  usersWinner: User[];

  constructor(public navCtrl: NavController, public http: HttpClient) {
    console.log(this.users);
    
  }

  ionViewDidEnter() {

  }

  AddUser() {
    if (this.users.find(x => x.name == this.user.name) == null) {
      for (let index = 0; index < this.users.length; index++) {
        if (this.users[index].name != null) {
          this.users[index] = this.user;
          break;
        }
      }
    }
    else{
      // ชื่อซ้ำ
    }
  }

  GetUsersWinner() {
    this.http.get<User[]>("https://localhost:5001/api/Values/GetUsersWinner")
      .subscribe(data => {
        this.usersWinner = data;
      });
  }

}
