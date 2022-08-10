namespace Sistema_Do_Caique
{
class Program{
    static void Main(string[] args)
{
    Endereco end = new Endereco();
    end.logradouro = "Rua X";
    end.numero = 100;
    end.complemento = "Qualquer coisa";
    end.enderecoComercial = false;

    PessoaFisica pf = new PessoaFisica();
    pf.endereco = end;
    pf.nome = "Caique Zaneti";
    pf.CPF = "6565151";
    pf.dataNascimento = new DateTime (1994, 05, 19);
//interpolacao
    Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} número {pf.endereco.numero}");
    //concatenacao
    Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + " número " + pf.endereco.numero);
    //forma burra
    Console.WriteLine(pf.endereco.logradouro);
    Console.WriteLine(pf.endereco.numero);
    Console.WriteLine(pf.endereco.complemento);

    bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

    if (idadeValida == true){
        System.Console.WriteLine("Cadastro Aprovado");
    }else{
        Console.WriteLine("Cadastro Reprovado");
    }
}
}
}

