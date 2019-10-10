using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    public class LocatarioModel
    {
        //Atributos da Classe

        public int Cpf { get; set; }         //PK
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Fumante { get; set; }
        public string Sexo { get; set; }
               
    }
}

