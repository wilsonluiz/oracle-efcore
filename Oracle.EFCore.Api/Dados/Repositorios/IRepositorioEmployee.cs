using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oracle.EFCore.Api.Auxiliares;
using Oracle.EFCore.Api.Dados.Entidades;

namespace Oracle.EFCore.Api.Dados.Repositorios
{
    public interface IRepositorioEmployee : IRepositorioBase<HrContext, Employee>
    {
        Task<List<Employee>> ListarEmployeesdAssincrono(ParametrosEmployee parametros);
    }
}