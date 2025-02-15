using System.Security.Cryptography;

namespace Energia
{
    public class program
    {
        public static void Main()
        {
            int m; //variável de massa

            double v1, v2 = 2; //variável de velocidade. Tive que fazer um double pois precisava realizar potencialização, a variável v2 já foi atribuita de antemão para facilitar mais pra frente

            Console.WriteLine("Programa de Cálculo de Energia Cinética\n");

            Console.WriteLine("Digite a massa: \n");

            m = int.Parse(Console.ReadLine()); //usuário fornece o valor da massa

            Console.WriteLine("\nDigite a velocidade: \n");

            v1 = int.Parse(Console.ReadLine()); //usuário fornece o valor da velocidade

            double potencia = Math.Pow(v1, v2); //aqui é realizada a potencialização utilizando Math Power, foi o melhor método que encontrei

            int ResultPot = Convert.ToInt32(potencia); //converte o Double potencia para int pois não conseguia realizar o cálculo tentando converter 

            int Ec = m * ResultPot / 2; /*multiplica a massa pelo double potencia convertido em ResultPot por 2, originalmente haveria a divisão 1/2 mas como não faz muita diferença
                                        decidi dividir tudo por 2 direto*/

            Console.WriteLine("Ec = 1/2 x " + m + " x " + v1 + "^2" + ResultPot + " = " + Ec); //mostra o resultado de forma bonita
        }
    }
}