// See https://aka.ms/new-console-template for more information

/*
Understanding Data Structure
1. What type would you choose for the following "numbers"
Telephone number: String
Height: Float or Double
Age: Int
Gender: Int(enum)? Char(Female: f, Male: m, N: Prefer not to say)
Salary: Decimal
ISBN: String
Price: Decimal
Shipping weight: Float or Double
Population: ulong
Number of Stars in the universe: ulong
Number of employees (up to 50,000): ushort
2.Difference between value type and reference type? What is Boxing and Unboxing?
1) Value types directly hold the value, while reference type hold the memory address (reference) for this value.
2) Also, Value types are stored in stack memory, while reference types are stored in heap memory. 
3) Operation on one value type cannot affect another value type, while operation on one reference type can affect another reference type
4) Value type will not be collected by garbage collector, while reference type will be
5) Value type can be created by Struct or Enum, but reference type can be created by class, interface, delegate, or array
6) Value type cannot accept Null value, while reference type can
Boxing: Converting a value type to a reference type and it can be done automatically
int i = 10;
object o = i;
Unboxing: Converting a reference type to a value type
int j = (int) o;
3.Managed resource and unmanaged resource in .NET
Managed resource are resources that are directly under the control of the garbage collector, while unmanged resource is not under the control of the garbage collector.
So for database connection, it's recommended that we write our code to ensure that .Dispose() is called on the connection object so that any unmanaged resources are cleaned up.
4. Purpose of Garbage Collector in .NET
Garbage collector is an automatic memory manager. It allocates objects on managed heap efficiently, and they release memory when the objects are no longer needed.
 */

// Console APP Playing
Console.WriteLine("Hello World?");
//Console.WriteLine('Hello World');
//string s = Console.ReadLine();
//Console.WriteLine(s);
Console.WriteLine("What's your favorite Color?");
string color = Console.ReadLine();
Console.WriteLine("What is your astrology sign?");
string astro = Console.ReadLine();
Console.WriteLine("What is your street address?");
string address = Console.ReadLine();
Console.WriteLine(color + astro + address);

// Practice Number Sizes and Ranges
//1. 
/*
outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.
 */

// num of bytes
// min and max values

void sizeRange(string dtype)
{
    switch (dtype)
    {
        case "sbyte":
            Console.WriteLine("Number of bytes: 1\nRange: -128 to 127");
            break;
        case "byte":
            Console.WriteLine("Number of bytes: 1\nRange: 0 to 255");
            break;
        case "short":
            Console.WriteLine("Number of bytes: 2\nRange: -32,768 to 32,767");
            break;
        case "ushort":
            Console.WriteLine("Number of bytes: 2\nRange: 0 to 65,535");
            break;
        case "int":
            Console.WriteLine("Number of bytes: 4\nRange: -2,147,483,648 to 2,147,483,647");
            break;
        case "uint":
            Console.WriteLine("Number of bytes: 4\nRange: 0 to 4,294,967,295");
            break;
        case "long":
            Console.WriteLine("Number of bytes: 8\nRange: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
            break;
        case "ulong":
            Console.WriteLine("Number of bytes: 8\nRange: 0 to 18,446,744,073,709,551,615");
            break;
        case "float":
            Console.WriteLine("Number of bytes: 4\nRange: +-1.0e-45 to +-3.4e38");
            break;
        case "double":
            Console.WriteLine("Number of bytes: 8\nRange: +-5e-324 to +-1.7e308");
            break;
        case "decimal":
            Console.WriteLine("Number of bytes: 16\nRange: +-1.0e-28 to +-7.9e28");
            break;
        default:
            Console.WriteLine("Wrong input!");
            break;
    }
}
sizeRange("byte");


// 2. Century Converting
void centuryConvert(int n)
{
    double micro = (double)(n * 3155673600000000);
    decimal nano = ((decimal)(n) * 3155673600000000000);
    Console.WriteLine(
        $"{n} centuries = {n * 100} years = {n * 36524} days = {n * 876576} hours = {n * 52594560} minutes = " +
        $"{n * 3155673600} seconds = {n * 3155673600000} milliseconds = {micro} microseconds = {nano} nanoseconds"
        );
}
centuryConvert(1);
centuryConvert(5);
centuryConvert(10);

/*
Controlling Flow and Converting Types 
1. What happens when you divide an int variable by 0?
DivideByZeroException is thrown
2. What happens when you divide a double variable by 0?
DivideByZeroException is thrown
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
When we go above the maximum value of the signed integer, the result usually becomes a negative number.
4. What is the difference between x = y++; and x = ++y;?
y++ means that increment happens after using y value, and ++y means increment happens before using y value.
5. What is the difference between break, continue, and return when used inside a loop
statement?
Break stops the loop and breaks it. Continue simply skips that loop and continue with next loops. Return is used when we reached desired result and return that result and exit the loop.
6. What are the three parts of a for statement and which of them are required?
First statement is executed before the execution of the code block, declare and initialize a local loop variable. Can't be accessed from outside of for loop
Second statement defines the condition for executing the code block.If it evaluates true, next iteration is executed. Must be a Boolean expression.
Third statement is executed every time after the code block has been executed. Defines what happens after each execution of the body of the loop. There can be multiple iterators.
all the sections of the for statement are optional.
for ( ; ;){
    infinite for loop
}
7. What is the difference between the = and == operators?
= is used to assigns value and == is an operator used to compare two values and return Boolean.
8. Does the following statement compile? for ( ; true; ) ;
Statement compiles. 
9. What does the underscore _ represent in a switch expression?
underscore(_) is used to replace default case. 
10. What interface must an object implement to be enumerated over by using the foreach
statement?
Object must implements System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T>
 */

// Practice Loops and Operators


// 1.fizz buzz game
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
    for (int i = 1; i <= 4; i++)
    {
        if (i == 1)
        {
            Console.Write(0);
            for (int j = 1; j <= 24; j += 1)
            {
                Console.Write(", " + j);
            }
            Console.WriteLine();
        }
        if (i == 2)
        {
            Console.Write(0);
            for (int j = 2; j <= 24; j += 2)
            {
                Console.Write(", " + j);
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