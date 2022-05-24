// See https://aka.ms/new-console-template for more information
/*
Understanding Data Structure

1. What type would you choose for the following "numbers"
Telephone number: String
Height: Float or Double
Age: Int
Gender: Int (enum)? Char (Female: f, Male: m, N: Prefer not to say)
Salary: Decimal
ISBN: String
Price: Decimal
Shipping weight: Float or Double
Population: ulong
Number of Stars in the universe: ulong
Number of employees (up to 50,000): ushort

2. Difference between value type and reference type? What is Boxing and Unboxing?

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


3. Managed resource and unmanaged resource in .NET

Managed resource are resources that are directly under the control of the garbage collector, while unmanged resource is not under the control of the garbage collector.
So for database connection, it's recommended that we write our code to ensure that .Dispose() is called on the connection object so that any unmanaged resources are cleaned up.

4. Purpose of Garbage Collector in .NET

Garbage collector is an automatic memory manager. It allocates objects on managed heap efficiently, and they release memory when the objects are no longer needed.

 */

// Console APP
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

// Practice number sizes and ranges
