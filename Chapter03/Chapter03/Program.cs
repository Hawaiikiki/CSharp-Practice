// See https://aka.ms/new-console-template for more information

1.fizz buzz game
void fizzbuzz()
{
    for (int i = 0; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 != 0)
        {
            Console.WriteLine("fizz");
        }
        else if (i % 3 != 0 && i % 5 == 0)
        {
            Console.WriteLine("buzz");
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("fizzbuzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
fizzbuzz();



//int max = 500;
//Console.WriteLine("following code causes overflow and infinite loop happens");
//for (byte i = 0; i < max; i++)
//{
//    Console.WriteLine(i);
//}

// console prints out numbers from 0 to 255. However, the loop never stops.
// problem is that byte's range is from 0 to 255. So it never reaches the max number and cannot exit the loop.



// 2. Print a Pyramid

void pyramid()
{
    int numberoflayer = 5, Space, Number;
    Console.WriteLine("Print paramid");
    for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
    {
        for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
            Console.Write(" ");
        for (Number = 1; Number <= i; Number++) //increase the value  
            Console.Write('*');
        for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
            Console.Write('*');
        Console.WriteLine();
    }
}
pyramid();

// 3. guess a num

void guess()
{
    int correctNum = new Random().Next(3) + 1;
    // random num between 1 and 3
    Console.WriteLine("Guess a number between 1 and 3");
    int guessedNum = int.Parse(Console.ReadLine());
    if (guessedNum >= 1 && guessedNum <= 3)
    {
        if (correctNum > guessedNum)
        {
            Console.WriteLine("you guessed lower number");
        }
        else if (correctNum < guessedNum)
        {
            Console.WriteLine("you guessed higher number");
        }
        else { Console.WriteLine("you guessed it right"); }
    }
    else
    {
        Console.WriteLine("your answer is out of range");
    }
}

guess();

// 4. days since birth

void daysBirth()
{
    var today = DateTime.Today;
    Console.WriteLine("Enter Birthdate in yyyy.mm.dd");
    var userInput = Console.ReadLine();
    DateTime birthdate;
    DateTime.TryParse(userInput, out birthdate);
    int n = (today - birthdate).Days;

    Console.WriteLine($"You are {n} days old");

    int daysToNextAnniversary = 10000 - (n % 10000);
    DateTime extracredit = today.AddDays(daysToNextAnniversary);
    Console.WriteLine($"Your 10000 days anniversary is {extracredit}");
}

daysBirth();

// 5. greeting message

void greeting()
{
    var hour = DateTime.Now.Hour;
    if (hour >= 6 && hour < 10)
    {
        Console.WriteLine("Good Morning");
    }
    else if (hour >= 10 && hour < 16)
    {
        Console.WriteLine("Good Afternoon");
    }
    else if (hour >= 16 && hour < 21)
    {
        Console.WriteLine("Good Evening");
    }
    else if (hour >= 21 && hour <= 24)
    {
        Console.WriteLine("Good Night");
    }
    else if (hour >= 0 && hour < 6)
    {
        Console.WriteLine("Time to Sleep!");
    }
}

greeting();

// 6. count to 24

void count24()
{
    for(int i=1; i <= 4; i++)
    {
        if (i == 1)
        {
            Console.Write(0);
            for (int j=1; j <= 24; j += 1)
            {
                Console.Write(", "+j);
            }
            Console.WriteLine();
        }
        if (i == 2)
        {
            Console.Write(0);
            for (int j = 2; j <= 24; j += 2)
            {
                Console.Write(", "+ j);
            }
            Console.WriteLine();
        }
        if (i == 3)
        {
            Console.Write(0);
            for (int j = 3; j <= 24; j += 3)
            {
                Console.Write(", " + j);
            }
            Console.WriteLine();
        }
        if (i == 4)
        {
            Console.Write(0);
            for (int j = 4; j <= 24; j += 4)
            {
                Console.Write(", " + j);
            }
            Console.WriteLine();
        }
    }
}

count24();