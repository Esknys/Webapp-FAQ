import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LagreComponent } from './Lagre/lagre.component';
import { ListeComponent } from './Liste/liste.component';

const appRoots: Routes = [
  { path:'liste', component: ListeComponent },
  { path:'lagre', component: LagreComponent },
  { path:'', redirectTo:'liste', pathMatch:'full' }
]

@NgModule({
  imports: [
    RouterModule.forRoot(appRoots)
  ],
  exports: [
    RouterModule
  ]
})

export class AppRoutingModule { }