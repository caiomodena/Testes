using System;
using System.Collections.Generic;
using System.Linq;
public class Calculadora
{

    public int valorSoma {get; set;}
    public double valorMedia {get; set;}
    List<int> listaInteiros = new List<int>();

    public void adicionaNumero(int num)
    {
        listaInteiros.Add(num);
    }

    public void somaNumerosLista()
    {
        valorSoma = listaInteiros.Sum();
    }

    public void mediaNumerosLista()
    {
        valorMedia = listaInteiros.Average();
    }

    public int somaNumeros(int num1, int num2)
    {
        return num1+num2;
    }
}