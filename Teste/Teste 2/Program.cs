using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, i = 0;
            while (i < 10)
            {
                i++;
                Console.Write("Digite a idade da pessioa {0}: ", i);
                int idade = int.Parse(Console.ReadLine());
                if (idade > 0 && idade < 100)
                {
                    if (idade > 0 && idade < 20) { cont1++; }
                    else if (idade > 20 && idade < 40) { cont2++; }
                    else if (idade > 40 && idade < 60) { cont3++; }
                    else { cont4++; }
                }

            }

            Console.WriteLine("Quantidade de pessoas dentro da faixa etária de 0 - 20 anos: {0}", cont1);
            Console.WriteLine("Quantidade de pessoas dentro da faixa etária de 21 - 41 anos: {0}", cont2);
            Console.WriteLine("Quantidade de pessoas dentro da faixa etária de 41 - 60 anos: {0}", cont3);
            Console.WriteLine("Quantidade de pessoas dentro da faixa etária de 61 - 100 anos: {0}", cont4);
        }
    }
}
