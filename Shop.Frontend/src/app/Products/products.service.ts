import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { take } from 'rxjs/operators';


export class Product {
    constructor() {
        this.id = -1;
    }
    id: number;
    name: string;
    description: string;
    price: number;
    pictureUrl: string;
    productType: string;
    productBrand: string;

}

@Injectable({
    providedIn: 'root'
})
export class ProductsService {
    baseUrl: string = 'https://localhost:5001/api/products';

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };


    constructor(private http: HttpClient) { }



    GetProducts(): Observable<Product[]> {
        return this.http.get<Product[]>(this.baseUrl)
            .pipe(take(1));
    }

    getProductById(id: number): Observable<Product> {
        const url = `${this.baseUrl}/${id}`;
        return this.http.get<Product>(url).pipe(take(1));
    }

    CreateProduct(product: Product): Observable<Product> {
        return this.http.post<Product>(this.baseUrl, product, this.httpOptions).pipe(take(1));
    }

    UpdateProduct(product: Product): Observable<void> {
        return this.http.put<void>(`${this.baseUrl}/${product.id}`, product,this.httpOptions).pipe(take(1));

    }
    DeleteProduct(product: Product | number): Observable<Product> {
        const id = typeof product === 'number' ? product : product.id;
        const url = `${this.baseUrl}/${id}`;

        return this.http.delete<Product>(url, this.httpOptions).pipe(take(1));
    }

}

