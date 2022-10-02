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

namespace problemas_aula_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para teste: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("o numero e par");
            }
            else
            {
                Console.WriteLine("o numero e impar");
            }
            Console.Read();
        }
    }
}