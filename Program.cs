// See https://aka.ms/new-console-template for more information

//caracteres de interpolação {}($") para melhor organização 
//Console.WriteLine= imprime mensagem na tela 
string aFriend = "Bill";
Console.WriteLine($"Hello,{aFriend}");
aFriend ="Maria";
Console.WriteLine($"Hello {aFriend}");
string firstFrienf = "Maria";
string secondFriend = "Sage" ;
Console.WriteLine($"My friends are {firstFrienf} and {secondFriend} ");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
Console.WriteLine($"The name {firstFrienf} has {firstFrienf.Length} letters.");
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

//CMD's TrimStart/TrimEnd/ Trim para organizar centralizando ou não//
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

//ABAIXO USO DO CMD Replace para substituição com a mesma string//
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

//CMD's ToUpper e ToLwer deixam a letra maiuscula e menuscula respectivamente
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

//CMD Contains ,Indica se uma cadeia de caracteres contém uma subcadeia de caracteres dentro dela.Estudar mais sobre isso amanhã,ou seja, se a palavra estiver na frase - true se não -false
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

//CMD's StartsWith e EndsWith também procuram subcadeias de caracteres em uma cadeia de caracteres. Eles encontram uma subcadeia de caracteres no início ou no final da cadeia de caracteres. 

string hello = "You say goodbye, and I say hello";
Console.WriteLine(hello.StartsWith("goodbye"));//Palavra "hello" não encontrada no começo da frase - false
Console.WriteLine(hello.EndsWith("hello"));//Palavra "hello" no final da frase - true 


