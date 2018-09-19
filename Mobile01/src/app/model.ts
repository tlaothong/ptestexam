import { HttpHeaders } from "@angular/common/http";

export class input {
    weight: number;
    height: number;
    bmi: number;
}

export class GlobalVarible {
    static host: string = "https://localhost:5001";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
}