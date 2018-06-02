using System;
using System.Globalization;

class DivisaoPares{

    string[] numeros;
    double num1, num2, divisao;
    public void LerNumeros(){
        int N = short.Parse(Console.ReadLine());

        for(int i = 0;i<N;i++){
            numeros = Console.ReadLine().Split(' ');
            if(numeros.Length>2){
                Console.WriteLine("Você digitou mais do que 2 números.");
                break;
            }
            num1 = double.Parse(numeros[0],CultureInfo.InvariantCulture);
            num2 = double.Parse(numeros[1],CultureInfo.InvariantCulture); 
            divisao = num1/num2;
            Console.WriteLine("A divisão dos números resulta em: {0}",divisao.ToString("F3",CultureInfo.InvariantCulture));          

        }     
        
        Console.ReadLine();       
        
    }

}