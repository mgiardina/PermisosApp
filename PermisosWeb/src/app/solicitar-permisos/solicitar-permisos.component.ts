import { Component, OnInit } from '@angular/core';
import { TipoPermisoService } from '../shared/tipo-permiso.service';
import { NgForm } from '@angular/forms';
import { PermisoService } from '../shared/permiso.service';
import { getLocaleDateTimeFormat } from '@angular/common';

@Component({
  selector: 'app-solicitar-permisos',
  templateUrl: './solicitar-permisos.component.html',
  styleUrls: []
})
export class SolicitarPermisosComponent implements OnInit {
    constructor(private tipoPermisoService: TipoPermisoService, private permisoService: PermisoService) { }
  ngOnInit() {
    this.tipoPermisoService.tiposPermisoList();
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.permisoService.formData = {
      Id: 0,
      TipoPermisoId: 0,
      NombreEmpleado: '',
      ApellidoEmpleado: '',
      FechaPermiso: new Date
    }
  }

  onSubmit(form: NgForm) {
    if (this.permisoService.formData.Id == 0)
      this.insertRecord(form);
  }

  insertRecord(form: NgForm) {
    console.log(this.permisoService.formData);
    this.permisoService.postPermiso().subscribe(
      res => {
        this.resetForm(form);
        alert('Permiso guardado');
      },
      err => {
        console.log(err);
      }
    )
  }
}
