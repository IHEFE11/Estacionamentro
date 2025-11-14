using System.Diagnostics.Contracts;
using C_;
Estacionamento e = new Estacionamento();
string? opcao;
e.apresentarValor();
while (true)
{
    Console.WriteLine("Digite um numero:");
    Console.WriteLine("1- Cadastrar carro(digite a placa)");
    Console.WriteLine("2- Remover carros(digite a placa)");
    Console.WriteLine("3- Listar carros");
    Console.WriteLine("4- Para encerrar");
    opcao=Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Coloque a placa do carro");
            e.cadastrarCarro();
            break;
        case "2":
            Console.WriteLine("Qual placa remover?");
            e.removerCarro();
            break;
        case "3":
            Console.WriteLine("Lista de carro");
            e.listarCarro();
            break;
        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("opção inválida");
            break;
    }
}