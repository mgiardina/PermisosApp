import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { AppComponent } from './app.component';
import { SolicitarPermisosComponent } from './solicitar-permisos/solicitar-permisos.component';
import { VerPermisosComponent} from './ver-permisos/ver-permisos.component';

const appRoutes: Routes = [
  {
    path: 'home',
    component: AppComponent,
  },
  {
    path: 'solicitar',
    component: SolicitarPermisosComponent,
  },
  {
    path: 'listar',
    component: VerPermisosComponent,
  }    
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      appRoutes,
      {
        enableTracing: false
      }
    )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
