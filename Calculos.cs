using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_Iniciais
{
    class Calculos
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Calcular se um número digitado é par!");
            Console.WriteLine("Digite o número: ");
            try{
                numero = short.Parse(Console.ReadLine()); 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
             

            Console.WriteLine("pfvr aparece algo na tela");

            //Console.WriteLine(numero.ToString());          

            /*
            if(numero % 2 == 0)
            {
                Console.WriteLine("É par!");
            }
            else
            {
                Console.WriteLine("É ímpar!");
            }      
             */
                 

        }
    }
}
