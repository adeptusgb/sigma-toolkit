using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaToolkit
{
    public static class FuncoesAuxiliares
    {
        public static int LerOpcaoDoMenu(int valorMinimo, int valorMaximo)
        {
            while (true)
            {
                Console.Write("Opcao: ");
                string? textoDigitado = Console.ReadLine();
                if (int.TryParse(textoDigitado, out int valorLido))
                {
                    if (valorLido >= valorMinimo && valorLido <= valorMaximo)
                    {
                        return valorLido;
                    }
                }
                Console.WriteLine("Opcao invalida. Tente novamente.");
            }
        }

        public static string LerCadeia()
        {
            while (true)
            {
                Console.Write("Cadeia: ");
                string? textoDigitado = Console.ReadLine();
                if (textoDigitado != null)
                {
                    return textoDigitado;
                }
                Console.WriteLine("Entrada invalida. Tente novamente.");
            }
        }

        public static void LimparTela()
        {
            Console.Clear();
        }
    }
}
