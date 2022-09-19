namespace Calculadora.Util
{
    public class Calculadora
    {
        public Calculadora(int limiteMinimo = 0)
        {
            LimiteMinimo = limiteMinimo;
        }

        public int LimiteMinimo { get; set; }

        public int Somar(int a, int b)
        {
            if(a < LimiteMinimo || b < LimiteMinimo)
            {
                throw new ArgumentOutOfRangeException("O argumento está abaixo do limite minimo");
            }
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            if (a < LimiteMinimo || b < LimiteMinimo)
            {
                throw new ArgumentOutOfRangeException("O argumento está abaixo do limite minimo");
            }
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Dividir(int a, int b)
        {
            throw new NotImplementedException();
        }

    }
}
