/* Crie um programa em C# que realize o seguinte:

Solicite ao usuário que insira seu nome completo.
Solicite ao usuário que insira sua idade.
Utilize métodos de string para realizar as seguintes operações:
Exiba o nome completo em maiúsculas.
Exiba o nome completo em minúsculas.
Conte o número de caracteres no nome completo (ignorando espaços em branco).
Converta a idade fornecida pelo usuário em um número inteiro.
Calcule o ano de nascimento do usuário com base na idade fornecida (supondo que o ano atual seja 2023).
Exiba o ano de nascimento calculado e a idade em que o usuário fará 100 anos.
Dicas:

Use os métodos ToUpper(), ToLower(), Length, Trim() e conversões para manipular as strings.
Use a classe Convert para converter a idade fornecida em um número inteiro.
Lembre-se de que o ano de nascimento pode ser calculado subtraindo a idade do ano atual (2023). */

using System;

namespace atividades
{
    class exercicio05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();

            Console.WriteLine("Nome completo em maiúsculas: " + nome.ToUpper());
            Console.WriteLine("Nome completo em minúsculas: " + nome.ToLower());
            Console.WriteLine("Número de caracteres no nome completo: " + nome.Length);
            Console.WriteLine("Idade: " + Convert.ToInt32(idade));
            Console.WriteLine("Ano de nascimento: " + (2023 - Convert.ToInt32(idade)));
            Console.WriteLine("Idade em que o usuário fará 100 anos: " + (100 - Convert.ToInt32(idade)));
        }
    }
}