using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTeste
{
    public class Mensagem
    {
        private string textoMensagem;
        public string TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

    }
}
