// See https://aka.ms/new-console-template for more information
//Como criar uma lista de nomes
var names = new List<string> { "<Lais>", "Ana", "Felipe" };
foreach (var Lais in names)
{
  Console.WriteLine($"Hello {Lais.ToUpper()}!");
}
//tipo List<T> armazena sequências de elementos. Especifique o tipo dos elementos entre os colchetes.
//eu posso remover(remove) ou adicionar(dd) a list
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
////O List<T> também permite fazer referência a itens individuais por List<T>. Acesse itens usando os tokens [ e ]
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
//os índices começam com 0, portanto, o maior índice válido é uma unidade a menos do que o número de itens na lista.(o item removido não aparece na contagem.)

//Para verificar a quantidade de "pessoas" na list:
Console.WriteLine($"The list has {names.Count} people in it");

//Para encontrar o item na lista usa-se index ;
var index = names.IndexOf("Felipe");
if (index != -1)
  Console.WriteLine($"The name {names[index]} is at index {index}");
  //Talvez você não saiba se um item está na lista, portanto, sempre verifique o índice retornado por IndexOf. Se for -1, o item não foi encontrado.

  // O Sort método classifica todos os itens na lista em sua ordem normal (em ordem alfabética para cadeias de caracteres).
  names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");

  //  Para o próximo assunto tudo acima deve ser apagado para melhor entendimento.
}
//Isso cria uma lista de números inteiros e define os primeiros dois inteiros como o valor 1. 
var fibonacciNumbers = new List<int> {1, 1};
// A Sequência de Fibonacci, uma sequência de números, começa com dois 1s. Cada número Fibonacci seguinte é encontrado considerando a soma dos dois números anteriores.
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);
  
  //Desafio
  //só pega se apagar os anteriores 
  
var fibonacciNumbers = new List<int> {1, 1};

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);