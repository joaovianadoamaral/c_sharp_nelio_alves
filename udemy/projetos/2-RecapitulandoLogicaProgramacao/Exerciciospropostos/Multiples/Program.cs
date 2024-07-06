namespace Exercise3 {
    internal class Program {
        static void Main(string[] args) {
            /*
             Leia 2 valores inteiros ( A e B ). 
            Após, o programa deve mostrar uma mensagem: 
            "São múltiplos" ou " Não são Múltiplos",
            indicando se os valores lidos são múltiplos entre si.

            atenção: os números podem ser digitados fora de ordem.
             */

            Console.Write("Digite o Primeiro número: ");
            int intNum1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo número: ");
            int intNum2 = int.Parse(Console.ReadLine());

            bool multiplos = false;

            if (intNum1 % intNum2 == 0 || intNum2 % intNum1 == 0) multiplos = true;

            if (multiplos) Console.WriteLine("MÚLTIPLOS");
            if (!multiplos) Console.WriteLine("NÃO MÚLTIPLOS");


        }
    }
}
