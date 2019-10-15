import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopBarComponent } from './components/shared/top-bar/top-bar.component';
import { TopNavigationComponent } from './components/shared/top-navigation/top-navigation.component';
import { MainDashboardComponent } from './components/dashboard/main-dashboard/main-dashboard.component';
import { EpochDashboardComponent } from './components/epoch/epoch-dashboard/epoch-dashboard.component';
import { ArtistDashboardComponent } from './components/artist/artist-dashboard/artist-dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    TopBarComponent,
    TopNavigationComponent,
    MainDashboardComponent,
    EpochDashboardComponent,
    ArtistDashboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
