using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyLibraryMVC.Models;


namespace EasyLibraryMVC.DAL
{
    public class LivroDAO
    {
        public static Context _context = new Context();

        public static List<Livro> ListarLivros => _context.Livros.ToList();

        public static void AdicionarLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public static Livro BuscarPorTitulo(string titulo) => _context.Livros.FirstOrDefault(x => x.Titulo.Contains(titulo));

        public static void Excluir(Livro livro)
        {
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }

        internal static void AtualizarLivro(Livro livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }
        public static bool IdentificadorJaExiste(Livro livro)
        {
            Livro livroExistente = _context.Livros.Where(x => x.IdentificadorUnico == livro.IdentificadorUnico).FirstOrDefault();
            if (livroExistente == null)
            {
                return false;
            }
            return true;
        }
    }
}
