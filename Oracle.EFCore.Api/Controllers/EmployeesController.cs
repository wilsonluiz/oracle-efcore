using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oracle.EFCore.Api.Auxiliares;
using Oracle.EFCore.Api.Dados.Entidades;
using Oracle.EFCore.Api.Dados.Repositorios;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepositorioEmployee _repositorio;

        public EmployeesController(IRepositorioEmployee repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> ObterAsync([FromQuery] ParametrosEmployee parametros)
        {
            return await _repositorio.ListarEmployeesdAssincrono(parametros).ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> ObterPorIdAsync([FromRoute] int id)
        {
            return await _repositorio.ObterPorIdAssincrono(id).ConfigureAwait(false);
        }
    }
}