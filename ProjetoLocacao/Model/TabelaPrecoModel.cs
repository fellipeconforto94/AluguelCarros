using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    class TabelaPrecoModel
    {
        //Atributos da Classe

        public int IdTabela { get; set; }         //PK
        public string Descricao { get; set; }
        public float ValorDiaria { get; set; }
        
    }
}
