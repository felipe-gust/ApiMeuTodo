using MeuTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Data
{
    // representação do BD em memória
    // usa essa classe para mapear a relação com o BD, ele faz um DE - PARA
    public class AppDataContext : DbContext
    {
        // DbSet = representação da tabela
        public DbSet<Todo>? Todos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");
        }

    }
}