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
        public void IsOdd_ValueLessInput0_ReturnFalse(int value)
        {
            //act (ação metodo a ser testado "unidade")
            var result = _sampleService.IsOdd(0);
            //assert (o cenario proposto no resultado do teste)
            assert.False();
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


    }
}