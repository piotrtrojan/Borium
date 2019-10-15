import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainDashboardComponent } from './components/dashboard/main-dashboard/main-dashboard.component';
import { EpochDashboardComponent } from './components/epoch/epoch-dashboard/epoch-dashboard.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'main',
    pathMatch: 'full'
  },
  {
    path: 'main',
    component: MainDashboardComponent
  },
  {
    path: 'epoch',
    component: EpochDashboardComponent
  },
  // {
  //   path: 'epoch/:id',
  //   component: ShowEpochComponent
  // },
  // {
  //   path: 'epoch/create',
  //   component: CreateEpochComponent
  // },
  // {
  //   path: 'artist/search',
  //   component: SearchArtistComponent
  // }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
