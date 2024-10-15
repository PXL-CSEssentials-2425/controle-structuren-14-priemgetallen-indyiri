

Console.WriteLine("Hier zijn alle getallen van 1 t.e.m 100, waarbij de priemgetallen in het rood staan en de andere in het groen");

for (int number = 1; number <= 100; number++)
{
    
    bool isPrimeNumber = true;

    for ( int dividend = 2; dividend < number; dividend++)   // of : for ( int dividend = 2; dividend <= (number/2); dividend++ )
    {
        if (number % dividend == 0)
        {
            isPrimeNumber = false;
        }
    }

    if (isPrimeNumber && number != 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    { 
        Console.ForegroundColor= ConsoleColor.Green;
    }

    Console.Write($"{number}\t");

    Console.ResetColor();

    if (number % 10 == 0)
    {
        Console.WriteLine();
    }
}