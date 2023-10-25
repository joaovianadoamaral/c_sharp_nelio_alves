namespace AtribuidoresAritmeticos {
    internal class Program {
        static void Main(string[] args) {

            double numero;

            numero = 25;
            double funcaoRaizQuadrada = Math.Sqrt(numero);
            Console.WriteLine(funcaoRaizQuadrada);

            numero = 8;
            double funcaoRaizCubica = Math.Cbrt(numero);
            Console.WriteLine(funcaoRaizCubica);

            //raiz do 2
            numero = 25;
            int grau = 2;
            double grauRaiz = (double) 1 / grau;
            double RaizFormaGeral = Math.Pow(numero, grauRaiz);
            double raizQuadradaNumero = RaizFormaGeral;
            Console.WriteLine(raizQuadradaNumero);

            //raiz do 3
            numero = 8;
            grau = 3;
            grauRaiz = (double) 1 / grau; 
            RaizFormaGeral = Math.Pow(numero, grauRaiz);
            double raizCubicaNumero = RaizFormaGeral;
            Console.WriteLine(raizCubicaNumero);


        }
    }
}