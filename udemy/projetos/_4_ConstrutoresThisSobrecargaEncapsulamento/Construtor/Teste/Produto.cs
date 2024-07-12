using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Produto
    {

        public Produto() {
            Console.WriteLine("oi");
        }
        public Produto(string nome, bool verdade) : this() 
        {
            Console.WriteLine(nome);
            Console.WriteLine(verdade);
        }





    }


}
