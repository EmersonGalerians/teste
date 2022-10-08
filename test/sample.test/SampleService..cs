using Xunit;

namespace Sample.Test
{
    public class SampleServiceTest
    {
        private readonly SampleService _sampleService;

        public SampleServiceTest()
        {
            //arange (qualquer tipo de variavel necessaria para montar o teste)
            _sampleService = new SampleService();
        }

        [Fact]
        public void IsOdd_ValueLessInput0_ReturnFalse()
        {
            //act (ação metodo a ser testado "unidade")
            var result = _sampleService.IsOdd(0);
            //assert (o cenario proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void IsEven_ValueLessInput0_ReturnTrue(int value) {
            var result = _sampleService.IsEven(value);
            Assert.False(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }
        [Theory]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void IsEven_ValueLessInput2_Return(int value) {
            var result = _sampleService.IsEven(value);

            Assert.True(result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Somar_NumeroRelativos_RetornarNumeroRelativo(int num1, int num2 , int valorEsperado) {
            var resultado = _sampleService.Sum(num1, num2);
            Assert.Equal(valorEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Subtrair_NumeroRelativos_RetornarNumeroRelativo(int num1, int num2, int valorEsperado)
        {
            var resultado = _sampleService.Sub(num1, num2);
            Assert.Equal(valorEsperado, resultado);
        }
    }
}