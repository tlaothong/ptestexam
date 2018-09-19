import { HttpHeaders } from "@angular/common/http";


export class Item {
    id: string
    name: string
    price: number
    Totalprice: number
    
}




export class GlobalVarible {
    static host: string = "https://localhost:5001/";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    

}