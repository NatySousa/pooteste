using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alô Mundo!";
            msg1.ExibirMensagem();
            Console.ReadKey();      
        }
    }
}
