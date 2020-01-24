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
    public class PermisoController : ControllerBase
    {
        private readonly IPermisoService _permisoService;

        public PermisoController(IPermisoService permisoService)
        {
            _permisoService = permisoService;
        }

        [HttpGet]
        public async Task<IEnumerable<PermisoApp>> List()
        {
            return await _permisoService.List();
        }

        [HttpGet("{permisoId}")]
        public async Task<ActionResult<PermisoApp>> Get(int permisoId)
        {
            try
            {
                return await _permisoService.Get(permisoId);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post(PermisoApp permiso)
        {
            try
            {
                return await _permisoService.Add(permiso);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpDelete("{permisoId}")]
        public async Task<ActionResult<bool>> Delete(int permisoId)
        {
            try
            {
                return await _permisoService.Delete(permisoId);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
