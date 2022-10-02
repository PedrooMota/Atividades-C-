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

namespace ATIVIDADE_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1° numero: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2° numero: ");
            int x = int.Parse(Console.ReadLine());

            if (n > x)
            {

                Console.WriteLine("o numero " + n + " e maior que " + x);
            }
            else
            {
                Console.WriteLine("o numero " + x + " e maior que " + n);
            }
            Console.WriteLine("PROGRAMA FINALIZADO!!");
            Console.Read();
        }
    }
}
