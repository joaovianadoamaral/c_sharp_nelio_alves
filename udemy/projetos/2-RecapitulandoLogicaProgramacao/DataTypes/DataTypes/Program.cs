using System;

namespace PrimeiroProjeto// Note: actual namespace depends on the project name.
{
    class Program {
        static void Main(string[] args) {

            //a quantidade de bytes define uma faixa de números
            
            //menor faixa de inteiro
            //valor máximo = 1 byte
            sbyte valorSbyte = 127;

            //exemplo de overflow
            SByte overFlow = -128;
            overFlow--;//overflow = 127

            //declaracao de um inteiro
            int inteiro = 10; //4 byte
            long inteiro2 = 20L; // 8 byte
            //usa-se o L para explicita um long


            //declaracao de um numero 'quebrado' = com virgula
            float numQuebrado = 10.5F; //4 byte
            //necessário o sufixo F no float
            double numQuebrado2 = 20.6; //8 byte

            //char
            //confira em : https://old.unicode-table.com/pt/
            //'\uCódigoUnicode';
            //use aspas simples
            char caractere = 'J';
            char uniCodeATil = '\u00E3';
            char caracterArroba = '\u0040';

            //bool
            bool valorVerdade = true;
            bool valorFalso = false;

            //string
            //use aspas duplas
            //cadeia de caracteres
            //imutável
            string nome = "João Vitor Viana do Amaral";
            nome = "Julia oliveira";
            //apenas reatribuição sem mudar o conteúdo original


            //object
            object qualquerCoisaEleAceita = 10.5f;


            //sbyte C# e .NET
            Console.WriteLine(valorSbyte);
            Console.WriteLine(overFlow);

            //int e long
            Console.WriteLine(inteiro);
            Console.WriteLine(inteiro2);

            //float e double
            Console.WriteLine(numQuebrado);
            Console.WriteLine(numQuebrado2);

            //char
            Console.WriteLine(caractere);
            Console.WriteLine(uniCodeATil);
            Console.WriteLine(caracterArroba);
            
            //bool
            Console.WriteLine(valorVerdade);
            Console.WriteLine(valorFalso);

            //string
            Console.WriteLine(nome);

            //object
            Console.WriteLine(qualquerCoisaEleAceita);


            //intervalo suportado pelo faixa do tipo
            int maiorNumeroInteiroFaixa = int.MaxValue;
            int menorNumeroInteiroFaixa = int.MinValue;

            float maiorNumeroFloatFaixa = float.MaxValue;
            float menorNumeroFloatFaixa = float.MinValue;

            Console.WriteLine(maiorNumeroInteiroFaixa);
            Console.WriteLine(menorNumeroInteiroFaixa);

            Console.WriteLine(menorNumeroFloatFaixa);
            Console.WriteLine(maiorNumeroFloatFaixa);


        }
    }
}