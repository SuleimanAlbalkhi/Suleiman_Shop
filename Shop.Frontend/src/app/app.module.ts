import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { WelcomeComponent } from './welcome/welcome.component';
import { PageNotFoundComponent } from './page-not-found.component';
import { ProductListComponent } from './Products/product-list/product-list.component';
import { ProductEditComponent } from './Products/product-edit/product-edit.component';
import { ProductCreateComponent } from './Products/product-create/product-create.component';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
    imports: [
        HttpClientModule,
        BrowserModule,
        AppRoutingModule,
        CommonModule,
        FormsModule,
        BrowserAnimationsModule,
        ToastrModule.forRoot()
    ],
    declarations: [
        AppComponent,
        WelcomeComponent,
        PageNotFoundComponent,
        ProductListComponent,
        ProductEditComponent,
        ProductCreateComponent
    ],
    bootstrap: [AppComponent],
    providers: []
})
export class AppModule { }