using Gerenciador_de_Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador_de_Tarefas.Context


{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext>options) : base(options)
        {

        }
            public DbSet<Tarefa> Tarefas {get; set;}

    }

}