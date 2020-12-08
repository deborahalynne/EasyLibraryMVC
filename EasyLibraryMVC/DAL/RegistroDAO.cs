using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyLibraryMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace EasyLibraryMVC.DAL
{
    public class RegistroDAO
    {
        public static Context _context = new Context();

        // retorna a quantidade de livros que um aluno está alugando no momento
        public static int LivrosEmPosse(Aluno aluno) => _context.Registros.Count(x => x.Aluno.Id == aluno.Id);

        public static void AdicionarRegistro(Registro registro)
        {
            _context.Registros.Add(registro);
            Livro livro = registro.Livro;
            livro.Quantidade -= 1;
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }

        // verifica se o aluno já alugou este livro
        public static bool LivroJaAlugado(Aluno aluno, Livro livro)
        {
            Registro registro = _context.Registros.FirstOrDefault(x => x.Aluno == aluno && x.Livro == livro);
            if (registro == null)
            {
                return false;
            }
            return true;
        }

        public static List<Registro> ListarRegistros(Aluno aluno) => _context.Registros.Where(x => x.Aluno == aluno).Include("Livro").ToList();

        public static void RemoverRegistro(Aluno aluno, Livro livro)
        {
            Registro registro = _context.Registros.FirstOrDefault(x => x.Aluno == aluno && x.Livro == livro);
            _context.Registros.Remove(registro);
            livro.Quantidade += 1;
            _context.Livros.Update(livro);
            _context.SaveChanges();

        }
    }
}

