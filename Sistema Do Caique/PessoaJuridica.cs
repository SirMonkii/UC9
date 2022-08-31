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

        public bool ValidarCNPJ(string CNPJ)
        {
            if (CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) == "0001")
                return true;
            else
            {
                return false;
            }
        }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                return rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                return rendimento * 8 / 100;
            }
            else if (rendimento > 10000)
            {
                return rendimento * 10 / 100;
            }else{
                return 0;
            }
        }
    }
}