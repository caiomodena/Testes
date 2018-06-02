using System;
using System.Globalization;

class MediaIdade
{
    int idade;
    double media;
    int soma = 0;
    int pos = 0;  
    public void LerIdades(){
        Console.WriteLine("Digite quantas idades quiser. Ao colocar uma idade negativa, " +
            "o programa irá parar e considerar todas idades positivas digitadas. Idades: ");        

           
        idade = int.Parse(Console.ReadLine());         
        while(idade>0)
        {            
            soma+=idade;
            pos++;
            idade = int.Parse(Console.ReadLine());            
        }                       
    }

    public void CalcularMedia(){        
        media = (double) soma / pos;
        Console.WriteLine("A média de idades é: {0}",media.ToString("F2",CultureInfo.InvariantCulture));
    }
}