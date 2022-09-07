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
            }
            else
            {
                return 0;
            }
        }
        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        //Criar o Database e o caminho para o mesmo

        public void Inserir(PessoaJuridica pj)
        {
            VerificarPastaArquivo(caminho);

            string[] pjstring = { $"{pj.nome}, {pj.CNPJ}, {pj.razaoSocial}" };

            File.AppendAllLines(caminho, pjstring);
        }

        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> listapj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.CNPJ = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listapj.Add(cadaPj);
        
            }
            return listapj;
        }
    }
}