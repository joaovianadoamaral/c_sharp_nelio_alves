namespace ConversaoImplicitaCasting {
    internal class Program {
        static void Main(string[] args) {

            byte valorPequeno;
            double valorGrande;

            valorGrande = 10.55;
            valorPequeno = (byte)valorGrande;

            Console.WriteLine(valorPequeno);
            //saída 10 = truncamento


            valorGrande = 256;
            valorPequeno = (byte)valorGrande;

            Console.WriteLine(valorPequeno);
            //OverflowException = saída 0

            valorGrande = 255;
            valorPequeno = (byte)valorGrande;

            Console.WriteLine(valorPequeno);
            //saída = 255 -> já que cabe no tipo byte


            int a = 5;
            int b = 2;
            float c = (float)a / b;
            Console.WriteLine(c);
            //saída : 2,5  
            //pelo menos um dos dois(a,b) tem que ser float para retornar um float

            double d = (double)10 / 8;
            Console.WriteLine(d);
            // saída 1.25

            double e = 10.0 / 8;
            Console.WriteLine(e);
            //saída 1.25
        }
    }
}