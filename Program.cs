using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_terreno {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, valorMetro, area, preco;

            Console.Write("Digite a largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do metro quadrado:");
            valorMetro = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimento;
            preco = valorMetro * area;

            Console.WriteLine("Area do terreno = " + area.ToString("F2",  CI));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", CI));
        }
    }
}
