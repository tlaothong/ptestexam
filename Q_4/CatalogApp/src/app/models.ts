
export class GlobalVariable {


    static host: string = "http://localhost:5000/";
    
   

}

export class Product{

    serial_number : string;
    name : string;
    amount : number;
    price : number;
    Ischecked : boolean;

}

export class ListPurchase {
    id: string;
    productList : Product[];
}
