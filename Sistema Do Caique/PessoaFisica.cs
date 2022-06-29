using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Do_Caique
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public DateTime dataNasc { get; set; }

    }
}