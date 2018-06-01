using System;
using Xunit;

namespace Exercicios_Iniciais
{
    public class TesteUnitario
    {                
        [Fact]
        public void VerificarAumentoNegativo()
        {
            Salario sal = new Salario(5000);
            double salarioFinal;            
            salarioFinal = sal.salario;
            //Assert.ThrowsAny(sal.calculaNovoSalarioPorPercentual(-5));
        }

        [Fact]
        public void VerificarSoma()
        {            
            Calculadora calc = new Calculadora();
            calc.adicionaNumero(4);
            calc.adicionaNumero(6);
            calc.somaNumerosLista();
            Assert.Equal(10,calc.valorSoma);
        }     

        [Theory]
        [InlineData(4, 6)]
        [InlineData(5, 5)]
        [InlineData(3, 7)]
        public void VerificarSomaInline(int a, int b)
        {
            Calculadora calc = new Calculadora();
            int num;
            num = calc.somaNumeros(a, b);
            Assert.Equal(10,num);
        }

        [Theory]
        [InlineData(4, 6, 10)]
        [InlineData(5, 5, 10)]        
        public void VerificarSomaInline2(int a, int b, int esperado)
        {
            Calculadora calc = new Calculadora();            
            int result = calc.somaNumeros(a, b);
            Assert.Equal(esperado,result);
        }       

/*
        [Theory]
        [ClassData(typeof(Calculadora))]
        public void VerificarSomaClassData(int a, int b)
        {
            Assert.Equal(10,a);
        }   
         */
    }
}