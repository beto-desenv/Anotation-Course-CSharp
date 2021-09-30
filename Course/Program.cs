using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ///ALGUNS DOS TIPOS BASICOS DE DADOS DO C#.

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green"; // ====>>>> "string" não é considerado TIPO BÁSICO 
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine();
            Console.WriteLine("TIPOS DE DADOS---------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            ///EXIBE O VALOR "MINIMO" OU "MÁXIMO" DE CADA TIPO DE DADO.

            int a1 = int.MinValue; //<<<<==== VALOR MÍNIMO PARA O TIPO "int"
            int a2 = int.MaxValue; //<<<<==== VALOR MÁXIMO PARA O TIPO "int"
            sbyte a3 = sbyte.MinValue;
            decimal a4 = decimal.MaxValue;

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            Console.WriteLine();
            Console.WriteLine("SAÍDA DE DADOS(CONSOLE)------------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Bom dia!"); // <===== Imprime na tela SEM QUEBRA DE LINHA
            Console.WriteLine("Boa tarde!"); //  <===== Imprime na tela COM QUEBRA DE LINHA
            Console.WriteLine("Boa noite");  //  <=====         (IGUAL)

            Console.WriteLine();
            Console.WriteLine("SAÍDA DE DADOS C/ CASAS DECIMAIS---------------------------------------------------------");
            Console.WriteLine();

            char _genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string _nome = "Maria";

            Console.WriteLine(_genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(_nome);
            Console.WriteLine(saldo.ToString("F2"));  // <=====  "F2, F3, F4..." declarada desta forma, serve para determinar o N° de CASAS DECIMAIS
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));  //  <===== Por padrão, ele vai desconsiderar qualquer formatação especifica de país.
                                                                                    //  (fazendo assim, estamos falando que queremos imprimir usando o "." como separador de decimais.)  
            Console.WriteLine();
            Console.WriteLine("PLACEHOLDER, CONCATENAÇÃO E INTERPOLAÇÃO-------------------------------------------------");
            Console.WriteLine();

            int _idade = 32;
            double _saldo = 10.35784;
            String nome1 = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome1, _idade, _saldo); // <===== "Placeholder": é como se fosse um lugar para entrar a variavel.
                                                                                                           //  0       1       2

            Console.WriteLine($"{nome1} tem {_idade} anos e tem saldo igual a {_saldo:F2} reais");  // <===== "Interpolação": desta forma fica com o código mais compacto.

            Console.WriteLine(nome1 + " tem " + idade + " anos e tem saldo igual a " + _saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");  //  <===== "Concatenação de Strings": é a junção de várias partes

            Console.WriteLine();
            Console.WriteLine("OPERADORES DE ATRIBUIÇÃO-----------------------------------------------------------------");
            Console.WriteLine();

            int a = 10; // <============= a variável "a" RECEBE o valor "10", ou seja, quando eu chamo a variável "a" no console, eu quero que imprima "10".
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF"; //  <==============Criou um novo "string" que é a "Concatenação" da string "s", ou seja, "+=" também serve para a "Concatenação Cumulativa de strings". 
            Console.WriteLine(s);

            Console.WriteLine();
            Console.WriteLine("OPERADOSRES ARITIMÉTICOS/ ATRIBUÍÇÃO-----------------------------------------------------");
            Console.WriteLine();

            int A = 10;
            A++;  // <============== O "A++" pegou o valor que ja existia(int A = 10;) e INCREMENTOU de "1", ou seja, ADICIONOU  1, virando "11".
            Console.WriteLine(A);

            A--;  // <============== O "A--" pegou o valor que ja existia(int A = 10;) e DECREMENTOU de "1", ou seja, SUBTRAIU  1, virando "10" novamente.
            Console.WriteLine(A);

            Console.WriteLine();
            Console.WriteLine("DIFERENÇA ENTRE A++ e ++A ou A-- e --A --------------------------------------------------");
            Console.WriteLine();

            int b = 10; // <====== Incrementado
            int c = b++;// <====== "b++" primeiro ele vai jogar o valor de "b" para o "c" que era "10",
                        // e depois vai INCREMENTAR o valor do "b", ai o "b" passou pra "11" e o "c" continua "10".
            Console.WriteLine(b);
            Console.WriteLine(c);

            int b1 = 10; 
            int c1 = ++b1;// <====== "++b" primeiro ele INCREMENTA o valor da variável "b" que valia "10" a passou a valer "11", depois ele atrinui o
                          // resultado para a variavel "c", então a variável "c" também passa a valer "11".
            Console.WriteLine(b1);
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.WriteLine("CONVERSÃO IMPLICITA E CASTING -----------------------------------------------------------");
            Console.WriteLine();

            ///CONVERSÃO IMPLÍCITA ENTRE TIPOS:
            ///É QUANDO UM CONTEÚDO DE UM CERTO "TIPO" PODE SER NATURALMENTE "ATRIBUIDO" PARA UMA VARIÁVEL DE OUTRO "TIPO".

            float x = 4.5f; // o "float" tem 4 Bytes e o "double" tem 8 Bytes.
            double y = x; // <============= Logo, essa operação é possível, pois o valor do "x"(float) cabe dentro de "y"(double).

            Console.WriteLine(y);
            Console.WriteLine();

            ///CONVERSÃO EXPLÍCITA DE TIPOS:

            double x1; 
            float y1; 

            x1 = 5.1; 
            y1 = (float)x1; // <====== é assim que é definido um CASTING, que é a CONVERSÃO EXPLICITA DE TIPOS.

            Console.WriteLine(y1);
            Console.WriteLine();

            ///2° EXEMPLO DE CASTING:

            double x2; // <===== o "int" tem 4 Bytes e só recebe valor "INTEIRO", já o "double" tem 8 Bytes e pode recebe um valor quebrado.
            int y2;
            // Para jogar um valor "double" dentro de uma variável "int", é necessário fazer o CASTING.
            x2 = 5.1;
            y2 = (int)x2; // <========= Porém nesse caso há perda de informação, os valores decimais após a virgula vão ser TRUNCADOS(cortados, perdidos).

            Console.WriteLine(y2);
            Console.WriteLine();

            ///3° EXEMPLO DE CASTING:

            int x3 = 5;
            int y3 = 2;
            // Tanto o valor de "a" quanto o valor de "b", são "int" que são valores inteiros, o compilador entendeu que você estava querendo divir 2 valores INTEIROS,
            // resultando em uma DIVISÂO INTEIRA, ele dividiu 5 / 2 que deveria ser 2,5 e descartou o valor após a "virgula", tornando o resultado "2", devemos nos atentar
            // a esse detalhe caso não queira que as casas DECIMAIS sejam descartadas.

            double resultado = (double) x3 / y3; // <=========== Pra que os valores Decimais seja respeitados, é necessário colocar um CASTING como no exemplo.

            Console.WriteLine(resultado);

            Console.WriteLine();
            Console.WriteLine("OPERADORES ARITIMÉTICOS------------------------------------------------------------------");
            Console.WriteLine();

            int m1 = 3 + 4 * 2;
            int m2 = (3 + 4) * 2;
            int m3 = 17 % 3;
            double m4 = 10.0 / 8.0; // ooouuu, podemos colocar um CASTING na operação, que ficaria: "double m4 = (double) 10 / 8;" e assim as casas decimais seriam respeitadas.

            //Fórmula de bascara
            double aa = 1.0, bb = -3.0, cc = -4.0;

            double delta = Math.Pow(bb, 2.0) - 4.0 * aa * cc;  //"b * b" = "b²" pode ser usado: "Math.Pow(b, 2.0)" ou se for: "b * b * b" = "b³" pode ser usado: "Math.Pow(b, 3.0)"

            double xx1 = (-bb + Math.Sqrt(delta)) / (2.0 * aa);  //Para calcular uma RAIZ QUADRADA é usado "Math.Sqrt()". 

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(delta);
            Console.WriteLine(xx1);

            Console.WriteLine();
            Console.WriteLine("ENTRADA DE DADOS (Digite seus dados no CONSOLE)------------------------------------------");
            Console.WriteLine();

            string frase = Console.ReadLine();
            string x11 = Console.ReadLine();
            string y11 = Console.ReadLine();
            string z11 = Console.ReadLine();


            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x11);
            Console.WriteLine(y11);
            Console.WriteLine(z11);
            
        }

    }
}
