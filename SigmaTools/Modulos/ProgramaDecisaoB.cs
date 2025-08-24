using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SigmaToolkit.Modulos
{
    internal static class ProgramaDecisaoB
    {
        public static void Rodar()
        {
            FuncoesAuxiliares.LimparTela();
            String? cadeia = FuncoesAuxiliares.LerCadeia();
            int result = FuncoesAuxiliares.EncontrarSimboloNaCadeiaQueNaoPertenceALinguagem(cadeia ?? "", ['a', 'b']);
            if (result == -1)
            {
                if (cadeia != null && cadeia.EndsWith('b'))
                {
                    Console.WriteLine("SIM");
                }
                else
                {
                    Console.WriteLine("NAO");
                }
            }
            else
            {
                Console.WriteLine($"Cadeia rejeitada. Simbolo '{cadeia?[result]}' na posicao {result} nao pertence ao alfabeto {{a,b}}.");
            }
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            FuncoesAuxiliares.LimparTela();
        }
    }
}
