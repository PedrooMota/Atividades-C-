/* ***********************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 23/02/2022
 * Autores do Projeto: Pedro Henrique Mota de Souza 
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: 
 * 
 * problema_aula.cs
 * ********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double anterior = 0;
            double atual = 1;
            double contador = 1;
            Console.WriteLine("Digite qual termo do fibonacci você deseja?  ");
            double c = double.Parse(Console.ReadLine());
            while (contador < c)
            {
                double proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
                contador += 1;
            }
            Console.WriteLine(atual);
            Console.WriteLine("Programa finalizado!");

            Console.Read();

        }
    }
}
