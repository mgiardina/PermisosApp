import { Component, OnInit } from '@angular/core';
import { PermisoService } from '../shared/permiso.service'; 

@Component({
  selector: 'app-ver-permisos',
  templateUrl: './ver-permisos.component.html',
  styleUrls: []
})
export class VerPermisosComponent implements OnInit {

  constructor(private service: PermisoService) { }

  ngOnInit() {
    this.service.permisosList();
  }

  onDelete(id) {
    if (confirm('Esta seguro que desea eliminar el permiso?')) {
      this.service.deletePermiso(id)
        .subscribe(res => {
          this.service.refreshList();
          alert('Permiso borrado');
        },
          err => {
            console.log(err);
          })
    }
  }
  
}
