import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Router } from '@angular/router';
import { AppComponent } from './app.component';
import { SolicitarPermisosComponent } from './solicitar-permisos/solicitar-permisos.component';
import { VerPermisosComponent } from './ver-permisos/ver-permisos.component';
import { AppRoutingModule } from './app.routing.module';
import { TipoPermisoService } from './shared/tipo-permiso.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule }   from '@angular/forms';
import { PermisoService } from './shared/permiso.service';

@NgModule({
  declarations: [
    AppComponent,
    SolicitarPermisosComponent,
    VerPermisosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule 
  ],
  providers: [TipoPermisoService, PermisoService],
  bootstrap: [AppComponent]
})
export class AppModule { 
  constructor(router: Router) {

  }
}
