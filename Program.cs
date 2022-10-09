using System;

namespace lanchonete
{
    class Program
    {
        static void Main(string [] args)
        {
            int cod;
            int quantidade, algo;
            int i;
            double valor = 0;
            double total;
            double totalgeral = 0;
            Console.WriteLine("***LANCHONETE KI'LARICA***");
            do
            {
                Console.Write("\n\n100 = Cachorro Quente---R$2,50");
                Console.Write("\n101 = Bauru Simples-----R$2,00");
                Console.Write("\n102 = Bauru com Ovo-----R$3,50");
                Console.Write("\n103 = Hambuerguer-------R$5,10");
                Console.Write("\n104 = Cheeseburguer-----R$3,30");
                Console.Write("\n105 = Refrigerante------R$2,00");
                Console.Write("\n\nDigite a opção desejada: ");
                cod = int.Parse(Console.ReadLine());
                Console.Write("\nInforme a quantidade: ");
                quantidade = int.Parse(Console.ReadLine());                                                         
                i = 0;
                switch (cod)
                {
                    case 100: valor = 2.50; break;
                    case 101: valor = 2.00; break;
                    case 102: valor = 3.50; break;
                    case 103: valor = 5.10; break;
                    case 104: valor = 3.30; break;
                    case 105: valor = 2.00; break;
                }
                i++;
                total = quantidade * valor;
                totalgeral = totalgeral + total;

                Console.WriteLine("\n\nValor ----------> R${0}",total);

            } while (i < 2);
        }
    }
}