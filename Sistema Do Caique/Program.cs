namespace Sistema_Do_Caique
{
    class Program
    {

        static void Main(string[] args)
        {
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            List<PessoaFisica> listaPF = new List<PessoaFisica>();

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
            !            Pessoa Física              !
            !            1 - Cadastrar              !
            !            2 - Listar                 !
            !            3 - Remover                !
            !                                       !
            !            Pessoa Jurídica            !
            !            4 - Cadastrar              !
            !            5 - Listar                 !
            !            6 - Remover                !
            =========================================
            !            0 - Sair                   !
            =========================================
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        /*
                            //cadastrar pessoa fisica
                            Endereco endPF = new Endereco();
                            Console.WriteLine("Digite seu logradouro");
                            endPF.logradouro = Console.ReadLine();

                            Console.WriteLine("Digite o numero da sua residencia");
                            endPF.numero = int.Parse(Console.ReadLine());

                            Console.WriteLine(@$"Digite o complemento da sua residencia
                            Pressione ENTER para pular");
                            endPF.complemento = Console.ReadLine();

                            Console.WriteLine("Este endereco eh comercial? (S/N)");
                            string endComercial = Console.ReadLine().ToUpper();
                            if (endComercial == "S")
                            {
                                endPF.enderecoComercial = true;
                            }
                            else
                            {
                                endPF.enderecoComercial = false;
                            }
                            */
                        PessoaFisica pf = new PessoaFisica();
                        //pf.endereco = endPF;
                        Console.WriteLine("Digite seu Nome");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite seu CPF (Somente Numeros)");
                        pf.CPF = Console.ReadLine();
                        /*
                                                Console.WriteLine("Digite o valor do seu salario");
                                                pf.salario = float.Parse(Console.ReadLine());

                                                Console.WriteLine("Digite sua data de aniversaio [AA, MM, DD] ");
                                                pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                                                bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

                                                if (idadeValida)
                                                {
                                                    Console.WriteLine("Cadastro Aprovado");
                                                    listaPF.Add(pf);
                                                    Console.WriteLine(pf.PagarImposto(pf.salario));
                                                }else{
                                                    Console.WriteLine("Cadastro Recusado, Muito novin");
                                                }
                        */
                        //StreamWriter sw = new StreamWriter($"{pf.nome}.txt");
                        //sw.Write($"{pf.nome}");
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write($"User {pf.nome}, CPF {pf.CPF}");
                        }

                        break;
                    case "2":
                        /*foreach (var cadaItem in listaPF)
                        {
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.CPF}");
                        }*/

                        Console.WriteLine("Digite o nome da pessoa que quer consultar");
                        string pessoa = Console.ReadLine();

                        using (StreamReader sr = new StreamReader($"{pessoa}.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                            Console.WriteLine($"Aperte 'ENTER' para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Digite o CPF do vascaino safado que tu quer apagar");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPF.Find(cadaItem => cadaItem.CPF == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPF.Remove(pessoaEncontrada);
                            Console.WriteLine("Vascaino eliminado");
                        }
                        else
                        {
                            Console.WriteLine("CPF nao encontrado");
                        }

                        break;
                    case "4":
                        novaPj.nome = "Nome PJ";
                        novaPj.CNPJ = "00.000.000/0001-00";
                        novaPj.razaoSocial = "Razaão Social Pj";

                        novoEndPj.logradouro = "Alameda Barão de Limeira";
                        novoEndPj.numero = 539;
                        novoEndPj.complemento = "SENAI Informática";
                        novoEndPj.enderecoComercial = true;

                        novaPj.endereco = novoEndPj;

                        metodoPj.Inserir(novaPj);


                        break;
                    case "5":
                        List<PessoaJuridica> listapj = metodoPj.Ler();
                        foreach (PessoaJuridica cadaItem in listapj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                        Nome: {novaPj.nome}
                        Razão Social: {novaPj.razaoSocial}
                        CNPJ: {novaPj.CNPJ}
                        
                        ");

                        }
                        Console.WriteLine($"Aperte 'ENTER' para continuar...");
                        Console.ReadLine();

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