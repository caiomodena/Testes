using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_Iniciais
{
    class Escolha
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valorDigitado = "";
            Console.WriteLine("Escolha a funcionalidade desejada.");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Livro de Receitas");
            Console.WriteLine("3 - Salário");

            valorDigitado = Console.ReadLine();

            if(int.TryParse(valorDigitado,out numero))
            {
                switch(numero)
                {
                    case 1: 
                            Calculadora calc = new Calculadora();
                            for(int i=0;i<4;i++)
                            {
                                Console.WriteLine("Digite número para ser adicionado à lista: ");
                                calc.adicionaNumero(short.Parse(Console.ReadLine()));                                
                            }
                            calc.somaNumerosLista();
                            calc.mediaNumerosLista();
                            Console.WriteLine("A soma dos números resulta em: {0} e a média resulta em {1}.",
                                calc.valorMedia,calc.valorSoma);
                        break;
                    case 2: 
                            Console.WriteLine("Digite nome da receita: ");
                            Receita receita = new Receita(Console.ReadLine());
                            Console.WriteLine("Digite nota da receita: ");
                            receita.notaReceita = short.Parse(Console.ReadLine());   
                            Console.WriteLine("Você cadastrou a receita {0}, com nota {1}.",
                                receita.nomeReceita,receita.notaReceita.ToString());                         
                        break;
                    case 3:
                            Console.WriteLine("Digite seu salário atual: ");
                            Salario salario = new Salario(Double.Parse(Console.ReadLine()));
                            Console.WriteLine("Digite o percentual de aumento: ");
                            salario.calculaNovoSalarioPorPercentual(double.Parse(Console.ReadLine()));
                            Console.WriteLine("Seu novo salário será de: {0}",salario.salario.ToString());
                            break;
                    default: Console.WriteLine("vamos almoçar");
                        break;
                }

            }            
        }
    }
}
