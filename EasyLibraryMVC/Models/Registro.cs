using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyLibraryMVC.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Secao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public Livro Livro { get; internal set; }
        public Aluno Aluno { get; internal set; }
    }
}
