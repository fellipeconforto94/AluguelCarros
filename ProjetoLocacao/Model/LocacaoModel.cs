﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    class LocacaoModel
    {
        //Atributos da Classe

        public int NumLocacao { get; set; }         //PK
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int ValorLocacao { get; set; }
        public int Cpf { get; set; }
        public int IdCarro { get; set; }
    }
}
