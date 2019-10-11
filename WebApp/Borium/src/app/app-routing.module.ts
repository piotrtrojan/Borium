import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  // {
  //   path: '',
  //   redirectTo: 'main',
  //   pathMatch: 'full'
  // },
  // {
  //   path: 'main',
  //   component: MainComponent
  // },
  // {
  //   path: 'epoch',
  //   component: MainEpochComponent
  // },
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
