using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_de_controle_C_ {
    internal class Program {
        static void Main(string[] args) {

            int hora;
            Console.WriteLine("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else {
                Console.WriteLine("Boa tarde!");
            }

        }
    }
}
