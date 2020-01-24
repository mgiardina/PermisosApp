import { Injectable } from '@angular/core';
import { TipoPermiso } from '../shared/tipo-permiso.model';
import { HttpClient } from '@angular/common/http';

@Injectable({  
    providedIn: 'root'  
  })  

export class TipoPermisoService {
    readonly url = 'https://localhost:44333/api/';
    tiposPermiso: TipoPermiso[];
    tipoPermiso: TipoPermiso;
    constructor(private http: HttpClient) { }

    tiposPermisoList() {
        this.http.get(this.url + 'tipopermiso').toPromise().then(result => this.tiposPermiso = result as TipoPermiso[])
    }

    tipoPermisoGet(id) {
        return this.http.get(this.url + '/tipopermiso/' + id).toPromise().then(result => this.tipoPermiso = result as TipoPermiso);
    }
}