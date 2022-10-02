/* *********
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 23/02/2022
 * Autores do Projeto: Pedro Henrique Mota de Souza 
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: 
 * 
 * problema_aula.cs
 * *******// *********
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 23/02/2022
 * Autores do Projeto: Pedro Henrique Mota de Souza 
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: 
 * 
 * problema_aula.cs
 * ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora para transformar em minutos!");
            int x = int.Parse(Console.ReadLine());

            int min = x * 60;

            Console.WriteLine("a hora convertida em minutos é: " + min);

            Console.Read();
        }
    }
}
        
    

