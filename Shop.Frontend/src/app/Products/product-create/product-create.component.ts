import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product, ProductsService } from '../products.service';
import { Location } from '@angular/common';
import { NotificationService } from 'src/app/notification.service';

@Component({
  selector: 'app-product-create',
  templateUrl: './product-create.component.html',
  styleUrls: ['./product-create.component.scss']
})
export class ProductCreateComponent implements OnInit {
  product: Product = {
    name: '',
    description: '',
    id: null,
    pictureUrl: '',
    price: 0,
    productBrand: '',
    productType: ''
  };

  constructor(
    private productService: ProductsService,
    private router: Router,
    private location: Location,
    private notifyService: NotificationService
  ) { }


  ngOnInit(): void {
  }

  create(): void {
    const observer = {
      next: _ => {
        this.notifyService.showSuccess('Creation was succesfull!', '');
      },
      error: _ => {
        this.notifyService.showError('There was an Error', '');
      }
    };

    this.productService.CreateProduct(this.product)
      .subscribe(observer);
    this.router.navigate(['/products']);
  }

  validate(): boolean {
    if (this.product.name.length == 0) {
      return false;
    }
    if (this.product.description.length == 0){
      return false;
    }
    if (this.product.price < 0) {
      return false;
    } 
    if (this.product.productBrand.length == 0) {
      return false;
    }
    if (this.product.productType.length == 0){
      return false;
    }
    if (this.product.pictureUrl.length == 0) {
      return false;
    }
    return true;
  }

  goBack(): void {
    this.location.back();
  }
 


}
