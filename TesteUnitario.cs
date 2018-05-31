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
    }
}
