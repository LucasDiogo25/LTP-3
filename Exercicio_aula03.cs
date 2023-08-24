// Lista de Exercícios em C# no 1.0

// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

using System;

    namespace numInteiro
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("O número digitado foi: " + numero);
            }
        }
    }

// 02 - Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

using System;
    namespace nomeUsuario
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite seu sobrenome: ");
                string sobrenome = Console.ReadLine();
                Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
            }
        }
    }

// 03 - Elabore um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.

using System;
    namespace calculadoraIdade
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite o ano de nascimento: ");
                int anoNascimento = Convert.ToInt32(Console.ReadLine());
                int anoAtual = DateTime.Now.Year;
                int idade = anoAtual - anoNascimento;
                Console.WriteLine("Sua idade é: " + idade);
            }
        }
    }

// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.

using System;
    namespace tabuada
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tabuada do " + numero);
                Console.WriteLine(numero + " x 0 = " + numero * 0);
                Console.WriteLine(numero + " x 1 = " + numero * 1);
                Console.WriteLine(numero + " x 2 = " + numero * 2);
                Console.WriteLine(numero + " x 3 = " + numero * 3);
                Console.WriteLine(numero + " x 4 = " + numero * 4);
                Console.WriteLine(numero + " x 5 = " + numero * 5);
                Console.WriteLine(numero + " x 6 = " + numero * 6);
                Console.WriteLine(numero + " x 7 = " + numero * 7);
                Console.WriteLine(numero + " x 8 = " + numero * 8);
                Console.WriteLine(numero + " x 9 = " + numero * 9);
                Console.WriteLine(numero + " x 10 = " + numero * 10);
            }
        }
    }

// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.

using System;
    namespace parImpar
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número " + numero + " é par.");
                }
                else
                {
                    Console.WriteLine("O número " + numero + " é ímpar.");
                }
            }
        }
    }

// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.

using System;
    namespace somaValores
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite um número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                if (numero1 == numero2)
                {
                    Console.WriteLine("O triplo da soma dos números é: " + (numero1 + numero2) * 3);
                }
                else
                {
                    Console.WriteLine("A soma dos números é: " + (numero1 + numero2));
                }
            }
        }
    }