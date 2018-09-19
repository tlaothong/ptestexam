import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

h:string;
w:string;
result:any = {};
  constructor(public navCtrl: NavController,private http: HttpClient) {

  }

  GetBMI() {
    this.http.get<any>("http://node17.codenvy.io:55659/api/values/GetBMI/"+this.w+"/"+this.h)
      .subscribe((data) => {
         console.log("Complete");
        this.result = data;
      },
        error => {
          alert("Error: " + error + "\nError message: " + error.message + "\nError result: " + error.error)
        });
  }
  
  
  
}
