/*Exercício: Derivação de Sentenças com uma Gramática Simples

Considere a seguinte gramática de exemplo:

1. S -> NP VP
2. NP -> Det N
3. NP -> N
4. VP -> V NP
5. Det -> 'o'
6. N -> 'gato' | 'cachorro'
7. V -> 'persegue' | 'late'

Aqui, S representa a sentença, NP o sintagma nominal, VP o sintagma verbal, Det o determinante, N o substantivo e V o verbo. As regras da gramática indicam como as sentenças podem ser formadas.

Tarefa:

Comece com a sentença inicial S.
Use as regras gramaticais para derivar uma sentença válida.
Escreva cada etapa da derivação até que você obtenha uma sentença terminal.
Conte o número de etapas até chegar ao final*/

using System;
    namespace atividade06
    {
        class exercicio06
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Exercício 06");

                Console.WriteLine("Derivação de Sentenças com uma Gramática Simples");

                Console.WriteLine("Considere a seguinte gramática de exemplo:");

                Console.WriteLine("1. S -> NP VP");
                Console.WriteLine("2. NP -> Det N");
                Console.WriteLine("3. NP -> N");
                Console.WriteLine("4. VP -> V NP");
                Console.WriteLine("5. Det -> 'o'");
                Console.WriteLine("6. N -> 'gato' | 'cachorro'");
                Console.WriteLine("7. V -> 'persegue' | 'late'");

                Console.WriteLine("Aqui, S representa a sentença, NP o sintagma nominal, VP o sintagma verbal, Det o determinante, N o substantivo e V o verbo. As regras da gramática indicam como as sentenças podem ser formadas.");

                Console.WriteLine("Tarefa:");

                Console.WriteLine("Comece com a sentença inicial S.");
                Console.WriteLine("Use as regras gramaticais para derivar uma sentença válida.");
                Console.WriteLine("Escreva cada etapa da derivação até que você obtenha uma sentença terminal.");
                Console.WriteLine("Conte o número de etapas até chegar ao final");

                Console.WriteLine("S -> NP VP");
                Console.WriteLine("S -> Det N VP");
                Console.WriteLine("S -> o N VP");
                Console.WriteLine("S -> o gato VP");
                Console.WriteLine("S -> o gato V NP");
                Console.WriteLine("S -> o gato persegue NP");
                Console.WriteLine("S -> o gato persegue Det N");
                Console.WriteLine("S -> o gato persegue o N");
                Console.WriteLine("S -> o gato persegue o cachorro");

                Console.WriteLine("Número de etapas: 8");
            }
        }
    }

