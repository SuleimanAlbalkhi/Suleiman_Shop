
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { WelcomeComponent } from './welcome/welcome.component';
import { PageNotFoundComponent } from './page-not-found.component';
import { ProductListComponent } from './Products/product-list/product-list.component';
import { ProductEditComponent } from './Products/product-edit/product-edit.component';
import { ProductCreateComponent } from './Products/product-create/product-create.component';

const appRoutes: Routes = [
    { path: 'home', component: WelcomeComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full'},
    { path: 'products', component: ProductListComponent },
    { path: 'products/new', component: ProductCreateComponent, pathMatch: 'full'},
    { path: 'products/:id', component: ProductEditComponent , pathMatch: 'full'},
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }