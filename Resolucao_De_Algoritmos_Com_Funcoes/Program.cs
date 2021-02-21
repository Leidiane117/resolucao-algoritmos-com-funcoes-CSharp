using System;

namespace Resolucao_De_Algoritmos_Com_Funcoes
{
    class Program
    {
        public static int Tabuada()
        {

            Console.WriteLine("Tabuada de 1 a 10");

            int multi = 0; ;
            int i = 0;
            while (i < 10)
            {

                i++;
                Console.WriteLine(" ");
                
                for (int j = 1; j <= 10; j++)
                {
                    multi = i * j;
                    Console.WriteLine(i+ " x " + j + " =  " + multi );
                }
            }
            return multi;
        }




        public static double CalculoDelta(int a, int b, int c)
        {
            Console.WriteLine("\nCalculo Função segundo grau\n");
            int delta = b * b - 4 * a * c; //cálculo do delta
            double raizQ = Math.Sqrt(delta); //Classe math com função sqrt para calcular a raíz quadrada de delta
            double raiz1 = (-b + raizQ) / 2 * a; //Cálculo das raízes da função
            double raiz2 = (-b - raizQ) / 2 * a;

            if (delta > 0) // Condições de acordo com resultado de delta
            {
                Console.WriteLine("A função possui duas raízes distintas: " + raiz1 + "  e  " + raiz2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("A função  possui uma raíz real: " + raiz1);
            }
            else
            {
                Console.WriteLine("A função não possui raíz real!");
            }
            return raiz1;
        
        }

        public  static double CalculoDesconto(string nome, double valor, int qtd)
        {
            Console.WriteLine("\nCalculo Desconto do Produto");
            double valorTot =0;
            if (qtd <= 10)
            {

                valorTot = valor - (0.00 * valor);
                Console.WriteLine("\n Nome:" + nome + "\n Valor: " + valor + " Reais " + "\n Valor com desconto : " + valorTot);
            }
            else if (qtd >= 11 && qtd <= 20)
            {

                valorTot = valor - (0.10 * valor);
                Console.WriteLine("\n Nome:" + nome + "\n Valor: " + valor + " Reais " + "\n Valor com desconto : " + valorTot);
            }
            else if (qtd >= 21 && qtd <= 50)
            {
                valorTot = valor - (0.20 * valor);
                Console.WriteLine("\n Nome:" + nome + "\n Valor: " + valor + " Reais " +  "\n Valor com desconto : " + valorTot);
            }
            else if (qtd > 50)
            {

                valorTot = valor - (0.25 * valor);
                Console.WriteLine("\n Nome:" + nome + "\n Valor: " + valor + "\n Valor com desconto : " + valorTot);
            }

            return valorTot;
        }



        static void Main(string[] args)
        {
            Program.Tabuada();
            Program.CalculoDelta(5, 3, 0);
            Program.CalculoDesconto("Liquidificador", 50.00, 10);

        }
    }
}
