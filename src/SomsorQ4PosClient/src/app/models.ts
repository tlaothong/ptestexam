import { HttpHeaders } from "@angular/common/http";

export class Product {
    id: string;
    name: string;
    serialNumber: string;
    unitPrice: number;
}
//property name start with lower case

export class GlobalVarible {
    static host: string = "https://localhost:5001";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
}
