using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Do_Caique
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public string razaoSocial { get; set; }

        public override void PagarImposto(float rendimento) { }

        public bool ValidarCNPJ(string CNPJ)
        {
            if (CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) == "0001")
                return true;
            else
            {
                return false;
            }
        }
    }
}