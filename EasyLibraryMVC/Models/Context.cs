using EasyLibraryMVC.Models;
using Microsoft.EntityFrameworkCore;
using EasyLibraryMVC.Models;

namespace EasyLibraryMVC.DAL
{
        public class Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Registro> Registros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object p = optionsBuilder.UseSqlServer("Password = admin123; Persist Security Info = True; User ID = sa; Initial Catalog = el2; Data Source = localhost\\SQLEXPRESS");
        }
    }
}