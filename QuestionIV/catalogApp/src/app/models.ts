import { HttpHeaders } from "@angular/common/http";

export class Item {
    id: string;
    name: string;
    serialNumber: string;
    price: number;
    isCheck : boolean;
}

export class GlobalVarible {
    static host: string = "http://kritna.azurewebsites.net";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
}