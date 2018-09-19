import { HttpHeaders } from "@angular/common/http";
import { DateTime } from "ionic-angular";

export class Product {
    id: string;
    name: string;
    serialNumber: string;
    unitPrice: number;
}

export class ProductPurchase extends Product {
    purchaseCount: number;
}

export class Order {
    id: string;
    purchaseDate: DateTime;
    totalPrice: number;
    products: ProductPurchase[];
}

export class GlobalVarible {
    static host: string = "https://localhost:5001";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
}
