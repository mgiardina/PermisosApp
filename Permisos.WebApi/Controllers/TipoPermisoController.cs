using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Permisos.Core.Domain.Entities;
using Permisos.Core.Interfaces;

namespace Permisos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPermisoController : ControllerBase
    {
        private readonly ITipoPermisoService _tipoPermisoService;

        public TipoPermisoController(ITipoPermisoService tipoPermisoService)
        {
            _tipoPermisoService = tipoPermisoService;
        }


        [HttpGet]
        public async Task<IEnumerable<TipoPermisoApp>> List()
        {
            return await _tipoPermisoService.List();
        }

        [HttpGet("{tipoPermisoId}")]
        public async Task<ActionResult<TipoPermisoApp>> Get(int tipoPermisoId)
        {
            try
            {
                return await _tipoPermisoService.Get(tipoPermisoId);
            }
            catch
            {
                return NotFound();
            }
        }

    }
}
