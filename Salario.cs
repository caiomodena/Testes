using System;

public class Salario
{
    public double salario {get; set;}

    public Salario(double salario)
    {
        this.salario = salario;
    }    
    public void calculaNovoSalarioPorPercentual(double percentualAumento)
    {
        if(percentualAumento < 0)
        {
            throw new Exception();
        }
        salario += (salario * (percentualAumento/100));        
    }
}