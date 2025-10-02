import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Product, ProductsService } from '../products.service';
import { Location } from '@angular/common';
import { NotificationService } from 'src/app/notification.service';



@Component({
  selector: 'app-product-edit',
  templateUrl: './product-edit.component.html',
  styleUrls: ['./product-edit.component.scss']
})
export class ProductEditComponent implements OnInit {
  products: Product[];
  product: Product;

  constructor(private productService: ProductsService,
    private route: ActivatedRoute,
    private router: Router,
    private location: Location,
    private notifyService: NotificationService
    ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get("id");
    this.getProduct(id);
  }

  getProduct(id: number): void {
    this.productService.getProductById(id)
      .subscribe(r => {
        this.product = r;
      });
  }

  save(): void {
    const observer = {
      next: _ => {
        this.notifyService.showSuccess('Saved succesfully!', '');
      },
      error: _ => {
        this.notifyService.showError('There was an Error', '');
      }
    };

    this.productService.UpdateProduct(this.product)
      .subscribe(observer);
      this.router.navigate(['/products']);

  }
  goBack(): void {
    this.location.back();
  }


  deleteProduct(productId: number): void {
    const observer = {
      next: _ => {
        this.notifyService.showSuccess('Deleted succesfully!', '');
      },
      error: _ => {
        this.notifyService.showError('There was an Error', '');
      }
    };
    this.productService.DeleteProduct(productId).subscribe(observer);
    this.router.navigate(['/products']);
  }

}


