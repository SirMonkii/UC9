using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Do_Caique
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public Endereco endereco { get; set; }

        public abstract void PagarImposto(float rendimento);

    }
}