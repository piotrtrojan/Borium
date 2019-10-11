import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopBarComponent } from './components/shared/top-bar/top-bar.component';
import { TopNavigationComponent } from './components/shared/top-navigation/top-navigation.component';

@NgModule({
  declarations: [
    AppComponent,
    TopBarComponent,
    TopNavigationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
