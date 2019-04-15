using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Oracle.EFCore.Api.Dados.Repositorios
{
    public interface IRepositorioBase<TContexto, TEntidade>
        where TContexto : DbContext
        where TEntidade : class
    {
        TEntidade ObterPorId(int id);
        List<TEntidade> ListarTodos();

        Task<TEntidade> ObterPorIdAssincrono(int id);
        Task<List<TEntidade>> ListarTodosAssincrono();
    }
}