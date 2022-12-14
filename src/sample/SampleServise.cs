using System;

namespace sample
{
    public class SampleService
    {
        //TODO: Criar um método que soma passando um total ou não e a partir do
        //segundo parâmetro podendo colocar varios números para realizar a subtração entre
        //eles ou a partir do total
        public decimal Sum(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }
        public decimal Sub(decimal numero1, decimal numero2)
        {
            return numero1 - numero2;
        }

        //TODO: Criar um método que verifica se o número é par
        public bool IsEven(int candidate)
        {
            if (candidate % 2 == 0)
            {
                return true;
            }
            return false;
        }

        //TODO: Criar um método que verifica se o número é impar
        public bool IsOdd(int candidate)
        {
            if (candidate % 2 != 0)
            {
                return false;
            }

            return true;

        }

        #region Verifica se o número é primo ou não
        public bool IsPrime(int candidate)
        {

            if (candidate < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor < Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}