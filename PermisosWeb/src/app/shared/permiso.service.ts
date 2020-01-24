import { Injectable } from '@angular/core';
import { Permiso } from '../shared/permiso.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})

export class PermisoService {
    readonly url = 'https://localhost:44333/api';
    permisos: Permiso[];
    formData: Permiso;
    constructor(private http: HttpClient) { }

    permisosList() {
        this.http.get(this.url + '/permiso').toPromise().then(result => this.permisos = result as Permiso[])
    }

    deletePermiso(id) {
        return this.http.delete(this.url + '/permiso/' + id);
    }

    postPermiso() {
        return this.http.post(this.url + '/permiso', this.formData);
    }

    refreshList() {
        this.http.get(this.url + '/permiso')
            .toPromise()
            .then(res => this.permisos = res as Permiso[]);
    }
}