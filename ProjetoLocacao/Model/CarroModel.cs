using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    public class CarroModel
    {   
        //Atributos da Classe

        public int IdCarro { get; set; }         //PK
        public string NumPlaca { get; set; }
        public bool TemAr { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public int QtdePortas { get; set; }
        public int IdTabela { get; set; }       //FK TabelaPreco
    }
}

