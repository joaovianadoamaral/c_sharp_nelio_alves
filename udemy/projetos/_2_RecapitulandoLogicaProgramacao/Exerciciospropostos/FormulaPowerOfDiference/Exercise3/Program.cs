namespace Exercise3 {
    internal class Program {
        static void Main(string[] args) {
            string num1String, num2String, num3String, num4String;
            int num1Int, num2Int, num3Int, num4Int;
            int formula;

            Console.WriteLine("Digite o primeiro número inteiro: ");

            num1String = Console.ReadLine();
            num1Int = int.Parse(num1String);

            Console.WriteLine("Digite o segundo número inteiro: ");

            num2String = Console.ReadLine();
            num2Int = int.Parse(num2String);

            Console.WriteLine("Digite o terceiro número inteiro: ");

            num3String = Console.ReadLine();
            num3Int = int.Parse(num3String);

            Console.WriteLine("Digite o quarto número inteiro: ");

            num4String = Console.ReadLine();
            num4Int = int.Parse(num4String);

            formula = num1Int * num2Int - num3Int * num4Int;
            Console.WriteLine("DIFERENÇA = " +  formula);
        }
    }
}