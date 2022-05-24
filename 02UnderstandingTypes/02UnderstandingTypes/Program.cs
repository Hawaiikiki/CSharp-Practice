// See https://aka.ms/new-console-template for more information

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