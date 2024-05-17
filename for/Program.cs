using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace @for {
    internal class Program {
        static void Main(string[] args) {

            int N, i, x, soma;

            Console.Write("Digite um numero: ");
            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (i = 1; i < N; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
