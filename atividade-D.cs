/* *********
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 23/02/2022
 * Autores do Projeto: Pedro Henrique Mota de Souza 
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: 
 * 
 * problema_aula.cs
 * *******/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Digite uma temperatura em Celsius: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite uma temperatura em Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());

                double x = (f - 32) * 5 / 9;
                double y = (c * 9 / 5) + 32;

                Console.WriteLine("A temperatura transformada para Fahrenheit ficou : " + y);

                Console.WriteLine("A temperatura transformada para Celsius ficou : " + x);

                Console.Read();
            
        }
    }
}
