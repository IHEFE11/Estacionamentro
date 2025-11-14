using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace C_
{
    public class Estacionamento
    {
        int valorInicial;
        int valorPorHora;
        string?[] Carros = new string?[10];

        public Boolean cadastrarCarro()
        {
            for (int i = 0; i < Carros.Length; i++)
            {
                if (Carros[i] == null)
                {
                    Carros[i] = Console.ReadLine();
                    return true;
                }
            }
            return false;
        }
        public void removerCarro()
        {
            string? x = Console.ReadLine();
            for (int i = 0; i < Carros.Length; i++)
            {
                if (Carros[i] != null && Carros[i] == x)
                {
                    Carros[i] = null;
                    Console.WriteLine("Carro Removido");
                }
                else
                {
                    Console.WriteLine("Esse placa nao esta registrada");
                    break;
                }
            }
            Console.WriteLine($"O valor cobrado foi: {valorInicial * valorPorHora}");
        }
        public void listarCarro()
        {
            for (int i = 0; i < Carros.Length; i++)
            {
                if (Carros[i] != null)
                {
                    Console.WriteLine($"Posicao {i + 1}--- placa {Carros[i]}");
                }
            }
        }
        public void apresentarValor()
        {
            Console.WriteLine("Digite o valor inicial:");
            valorInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora:");
            valorPorHora = Convert.ToInt32(Console.ReadLine());
        }
    }
}