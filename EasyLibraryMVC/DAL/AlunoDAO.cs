using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyLibraryMVC.Models;
using EasyLibraryMVC.Controllers;

namespace EasyLibraryMVC.DAL
{
    public class AlunoDAO
    {
        public static Context _context = new Context();

        public static List<Aluno> Listar() => _context.Alunos.ToList();
        public static List<Aluno> BuscarPorNome(string nome) =>

            _context.Alunos.Where(x => x.Nome.Contains(nome)).ToList();

        public static Aluno BuscarPorCPF(string cpf) =>
            _context.Alunos.FirstOrDefault(x => x.Cpf == cpf);


        public static void AdicionarAluno(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public static void AtualizarAluno(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }

        public static void Excluir(Aluno aluno)
        {
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }
    }
}