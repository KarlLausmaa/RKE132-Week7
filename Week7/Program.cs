Console.WriteLine("Coming or leaving? (in/out)");

string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}





//PrintHello();
//PrintGoodBye();

static void PrintHello()
{
    Console.WriteLine("Hi");
}

static void PrintGoodBye()
{
    Console.WriteLine("Bye");
}
