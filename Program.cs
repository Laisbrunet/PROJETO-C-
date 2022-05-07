// See https://aka.ms/new-console-template for more information
//Tipos numérico(Matemática c#)

int a = 18;
int b = 6;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

// subtraction
c = a - b;
Console.WriteLine(c);

// multiplication
c = a * b;
Console.WriteLine(c);

// division
c = a / b;
Console.WriteLine(c);

//Posso utilizar qualquer operação matemática 

c = a + b - 12 * 17;
Console.WriteLine(c);

//parênteses para delimitar a operação, ou operações, que você quer realizar primeiro. 
d = (a + b) * c;
Console.WriteLine(d);

//decimal
int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
Console.WriteLine(h);


//Limite do tipo int 
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

//Tipo double, ex 1
double i = 5;
double j = 4;
double k = 2;
double l = (i + j) / k;
Console.WriteLine(l);
//Função double é semelhante a função int ,representa um número de ponto flutuante de precisão dupla.Precisão dupla é um termo relativo que descreve o número de dígitos binários usados para armazenar o valor.

//Tipo double , ex 2
double m = 19;
double n = 23;
double o = 8;
double p = (m + n) / o;
Console.WriteLine(p);

double maxi = double.MaxValue;
double mini = double.MinValue;
Console.WriteLine($"The range of double is {mini} to {maxi}");
//Esses valores são impressos em notação científica
//Double ex 3
double third = 1.0 / 3.0;
Console.WriteLine(third);
//Desafio pessoal
double deci = 6.75 / 7.90;
Console.WriteLine(deci);
//O tipo decimal tem um intervalo menor, mas precisão maior do que double. 
//Tipo decimal limite
decimal minim = decimal.MinValue;
decimal maxim = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minim} to {maxim}");
//Comparação:
double q = 1.0;
double r = 3.0;
Console.WriteLine(q / r);

decimal s = 1.0M;
decimal t = 3.0M;
Console.WriteLine(s / t);
//O sufixo M nos números é o modo como você indica que uma constante deve usar o tipo decimal. Caso contrário, o compilador assumirá o double tipo .
//desafio pessoal: Calcular a área de um circulo;
double radius = 2.50;
double area = Math.PI * radius * 2.50;// radius*radius
Console.WriteLine(area);

