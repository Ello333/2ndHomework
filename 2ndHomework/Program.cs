// See https://aka.ms/new-console-template for more information

string greeting = "Hi! What's your name?";
Console.WriteLine();
string age = "How old are you?";

Console.WriteLine(greeting);
Console.WriteLine();
string firstname = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Hello, {firstname} !");

Console.WriteLine();
Console.WriteLine(age);
Console.WriteLine();
string yourageText = Console.ReadLine();
int yourage = int.Parse(yourageText);
Console.WriteLine();
//int result = yourage + 1;
yourage = yourage + 1;
Console.WriteLine($"Next year you will be {yourage} years old.");
Console.WriteLine();
Console.WriteLine("What's your favorite number?");
Console.WriteLine();
string favoritenumberText = Console.ReadLine();
int favoritenumber = int.Parse(favoritenumberText);
Console.WriteLine();
Console.WriteLine("Enter the last 2 numbers of your phone number?");
Console.WriteLine();
string phoneText = Console.ReadLine();
Console.WriteLine();
int phone = int.Parse(phoneText);
int maxresult = Math.Max(favoritenumber, phone);
Console.WriteLine($"{ maxresult} is a bigger number.");
int minresult = Math.Min(favoritenumber, phone);
Console.WriteLine();
Console.WriteLine($"{minresult} is a smaller number.");
Console.WriteLine();

Console.WriteLine("Choose a number between 1 - 100 ?");
Console.WriteLine();
string number1text = Console.ReadLine();
Console.WriteLine("Choose a number between 10 - 90?");
Console.WriteLine();
string number2text = Console.ReadLine();

int number1 = int.Parse(number1text);
int number2 = int.Parse(number2text);

int atlikums = number1 % number2;
Console.WriteLine();
Console.WriteLine($"{atlikums} ir dalījuma atlikums");
Console.WriteLine();


Console.WriteLine("What year you were born?");
Console.WriteLine();
string number3text = Console.ReadLine();
Console.WriteLine();
int number3 = int.Parse(number3text);

int evenodd = (number3 % 2);

if (number3 % 2 == 0)
{
    Console.WriteLine("This number is even.");
}
else
{
    Console.WriteLine("This number is odd.");
}
Console.WriteLine();

Console.WriteLine("Choose a number between 1-20 for your rectangle's edge?");
string number5text = Console.ReadLine();   
Console.WriteLine();
Console.WriteLine("Choose a number between 5-40 for the other edge?");
string number6text = Console.ReadLine();

decimal number5 = decimal.Parse(number5text);
decimal number6 = decimal.Parse(number6text);
decimal area1 = number6 * number5;


Console.WriteLine();
Console.WriteLine($"The field's size for your rectangle is {area1}");

Console.WriteLine();
decimal area2 = number5 * number6 / 2;
Console.WriteLine($"The area of a field in the shape of a triangle would be {area2}.");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Write your username?");
string username = Console.ReadLine();
Console.WriteLine( );
Console.WriteLine("How old are you?");
Console.WriteLine();
string howold = Console.ReadLine();
Console.WriteLine($"Hi {username}, your age is {howold}");







