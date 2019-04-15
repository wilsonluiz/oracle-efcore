using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.EFCore.Api.Dados.Entidades;
using Oracle.ManagedDataAccess.Client;

namespace Oracle.EFCore.Api.Dados
{
    public class HrContext : DbContext
    {
        private readonly IConfiguration _configuracao;

        public HrContext(IConfiguration configuracao) : base ()
        {
            _configuracao = configuracao;
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(_configuracao["StringsConexao:HrContexto"]);
        }

        private static OracleConnection ObterConexao(string stringConexao)
        {
            if (string.IsNullOrEmpty(stringConexao))
                throw new ArgumentException($"Necessário informar a string de conexão para o contexto {nameof(HrContext)}");

            return new OracleConnection(stringConexao);
        }
    }
}