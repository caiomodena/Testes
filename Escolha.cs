using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

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
            Console.WriteLine("4 - Média de Idades");
            Console.WriteLine("5 - Divisão de Pares");

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
                                calc.valorSoma,calc.valorMedia);

                            Console.WriteLine("Digite dois números para serem somados, separados por espaço: ");
                            string[] vetor = Console.ReadLine().Split(' ');
                            int valorSoma;
                            valorSoma = calc.somaNumeros(int.Parse(vetor[0]),int.Parse(vetor[1]));
                            Console.WriteLine("A soma resultou em: {0}",valorSoma);
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
                            salario.calculaNovoSalarioPorPercentual(Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
                            Console.WriteLine("Seu novo salário será de: {0}",salario.salario);
                            break;
                    case 4:
                            MediaIdade mediaIdade = new MediaIdade();
                            mediaIdade.LerIdades();
                            mediaIdade.CalcularMedia();
                            break;
                    case 5:
                            DivisaoPares divisaoPares = new DivisaoPares();
                            divisaoPares.LerNumeros();                            
                            break;
                    default: Console.WriteLine("vamos almoçar");
                        break;
                }

            }            
        }
    }
}
