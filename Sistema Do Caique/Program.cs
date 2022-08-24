namespace Sistema_Do_Caique
{
    class Program
    {

        static void Main(string[] args)
        {

            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(texto);
                for (var contador = 0; contador < 10; contador++)
                {
                    Thread.Sleep(300);
                    Console.Write("#");
                };
            }


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@$"
            ==========================================
            !                                        !
            !    Bem vindo ao Sistema de cadastros   !
            ! de pessoas fisicas e pessoas juridicas !
            !                                        !
            ==========================================
            ");
            

            BarraCarregamento("Iniciando ");

            string? opcao;

            do
            {
                Console.WriteLine(@$"
            =========================================
            !      Escolha uma das opcoes abaixo    !
            =========================================
            !                                       !
            !           1 - Pessoa Fisica           !
            !           2 - Pessoa Juridica         !
            !                                       !
            !           0 - Sair                    !
            !                                       !
            =========================================
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Rua X";
                        endPf.numero = 100;
                        endPf.complemento = "Qualquer coisa";
                        endPf.enderecoComercial = false;

                        PessoaFisica Lucas = new PessoaFisica();
                        Lucas.endereco = endPf;
                        Lucas.nome = "Lucas Rodriguez Sinni";
                        Lucas.CPF = "6565151";
                        Lucas.dataNascimento = new DateTime(2004, 08, 21);

                        Console.WriteLine(Lucas.CPF);
                        Console.WriteLine(Lucas.dataNascimento.ToString("dd/MM/yyyy"));
                        break;

                    case "2":
                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua X";
                        endPj.numero = 100;
                        endPj.complemento = "Qualquer coisa";
                        endPj.enderecoComercial = true;

                        PessoaJuridica pj = new PessoaJuridica();
                        pj.CNPJ = "151515151515150001";
                        pj.endereco = endPj;
                        pj.razaoSocial = "Pessoa Juridica";
                        pj.nome = "Jequiti";

                        Console.WriteLine(pj.CNPJ);
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por ultilizar o nosso sistema");
                        BarraCarregamento("Finalizando ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.WriteLine("O VASCAINO DESGRACADO TU EH BURRO?");

                        break;
                }
            } while (opcao != "0");

            Console.ResetColor();

        }



        /* static void Main(string[] args)
         {
             Endereco endPf = new Endereco();
             end.logradouro = "Rua X";
             end.numero = 100;
             end.complemento = "Qualquer coisa";
             end.enderecoComercial = false;

             PessoaFisica pf = new PessoaFisica();
             pf.endereco = end;
             pf.nome = "Caique Zaneti";
             pf.CPF = "6565151";
             pf.dataNascimento = new DateTime(1994, 05, 19);
             //interpolacao
             Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} número {pf.endereco.numero}");
             //concatenacao
             Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + " número " + pf.endereco.numero);
             //forma burra
             Console.WriteLine(pf.endereco.logradouro);
             Console.WriteLine(pf.endereco.numero);
             Console.WriteLine(pf.endereco.complemento);

             bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

             if (idadeValida == true)
             {
                 System.Console.WriteLine("Cadastro Aprovado");
             }
             else
             {
                 Console.WriteLine("Cadastro Reprovado");
             }

             PessoaJuridica pj = new PessoaJuridica();
             pj.CNPJ = "151515151515150001";

             bool CNPJValido = pj.ValidarCNPJ(pj.CNPJ);

             if (CNPJValido == true)
             {
                 Console.WriteLine("CNPJ CERTIN MALUCO");
             }
             else
             {
                 Console.WriteLine("CNPJ ERRADO PRA KRAIO");
             }
         }
         */
    }
}