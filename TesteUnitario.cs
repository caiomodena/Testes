using System;
using Xunit;

namespace Exercicios_Iniciais
{
    public class TesteUnitario
    {
        [Fact]
        public void PassandoTeste()
        {
            Assert.Equal(4, Add(2, 2));
        }
        
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }
        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
