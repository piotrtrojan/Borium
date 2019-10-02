import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './components/main/main/main.component';
import { SearchArtistComponent } from './components/artist/search-artist/search-artist.component';
import { MainEpochComponent } from './components/epoch/main-epoch/main-epoch.component';
import { ShowEpochComponent } from './components/epoch/show-epoch/show-epoch.component';
import { CreateEpochComponent } from './components/epoch/create-epoch/create-epoch.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'main',
    pathMatch: 'full'
  },
  {
    path: 'main',
    component: MainComponent
  },
  {
    path: 'epoch',
    component: MainEpochComponent
  },
  {
    path: 'epoch/:id',
    component: ShowEpochComponent
  },
  {
    path: 'epoch/create',
    component: CreateEpochComponent
  },
  {
    path: 'artist/search',
    component: SearchArtistComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
