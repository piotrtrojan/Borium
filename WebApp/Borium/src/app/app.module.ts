import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowEpochComponent } from './components/epoch/show-epoch/show-epoch.component';
import { ShowArtistComponent } from './components/artist/show-artist/show-artist.component';
import { CreateEpochComponent } from './components/epoch/create-epoch/create-epoch.component';
import { CreateArtistComponent } from './components/artist/create-artist/create-artist.component';
import { CreateWorkComponent } from './components/work/create-work/create-work.component';
import { ShowWorkComponent } from './components/work/show-work/show-work.component';
import { SearchArtistComponent } from './components/artist/search-artist/search-artist.component';
import { MainComponent } from './components/main/main/main.component';
import { TopMenuComponent } from './components/main/top-menu/top-menu.component';
import { MainEpochComponent } from './components/epoch/main-epoch/main-epoch.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowEpochComponent,
    ShowArtistComponent,
    CreateEpochComponent,
    CreateArtistComponent,
    CreateWorkComponent,
    ShowWorkComponent,
    SearchArtistComponent,
    MainComponent,
    TopMenuComponent,
    MainEpochComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
