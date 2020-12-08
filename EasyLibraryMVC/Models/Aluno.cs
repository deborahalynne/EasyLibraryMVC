using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyLibraryMVC;
using EasyLibraryMVC.DAL;
using EasyLibraryMVC.Controllers;

namespace EasyLibraryMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Curso { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Endnum { get; set; }
    }

}
