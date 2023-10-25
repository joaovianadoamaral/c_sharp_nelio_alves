namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {
            int num1int, num2int, sum;
            string num1String, num2String;

            Console.WriteLine("Digite o primeiro número: ");
            
            num1String = Console.ReadLine();
            num1int = int.Parse(num1String);

            Console.WriteLine("Digite o segundo número: ");
            
            num2String = Console.ReadLine();
            num2int = int.Parse(num2String);

            sum = num1int + num2int;

            Console.WriteLine($"SOMA = {sum}");
        }

    }
}