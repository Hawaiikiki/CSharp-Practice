// See https://aka.ms/new-console-template for more information
using System.Linq;
/*
1. When to use String vs. StringBuilder in C# ?

If a string is going to remain constant throughout the program, we should use String class object since a String object is immutable.
However, if a string can change, then we should use a StringBuilder.
string -> StringBuilder
string str = "hey";
StringBuilder sb = new StringBuilder(str);
sb.append("hello");
StringBuilder -> string
string str2 = sb.ToString();


2. What is the base class for all arrays in C#?

There is an abstract class Array, which is the base type of all array types.

3. How do you sort an array in C#?

Array.Sort() method takes array as an input and sorts the array in ascending order. We can use Array.Reverse() to sort an array in descending order.

4. What property of an array object can be used to get the total number of elements in
an array?

Array.Length property is used to get the total number of elements in all dimensions of the array.

5. Can you store multiple data types in System.Array?

Yes, we can create an object type array to stroe multiple data types. 

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

CopyTo() method copies the elements into another existing array, while Clone() method returns a new array object containing all the elements in the original way.
Both methods peform shallow copy. CopyTo() requires destination array and destination array needs to be large enough to hold the copied elements.

 */

// Practice String part 1

// 1. Copying an array

//int[] arr1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int[] arr2 = new int[arr1.Length];

//for (int i=0;i<arr1.Length;i++)
//{
//    arr2[i] = arr1[i];
//}
//foreach (int i in arr1)
//{
//    Console.Write(i);
//}
//foreach (int i in arr2)
//{
//    Console.Write(i);
//}


// 2. Manage a list

//List<string> customList = new List<string>();
//for (; ; )
//{
//    Console.WriteLine("Enter command (+ item, - item, or -- to clear)): ");
//    string command = Console.ReadLine();
//    if (command[0] == '+')
//    {
//        customList.Add(command.Substring(2));
//    }
//    if (command.Substring(0,2) == "- ")
//    {
//        customList.Remove(command.Substring(2));
//    }
//    if (command.Substring(0,2) == "--")
//    {
//        customList.Clear();
//    }
//    foreach(string item in customList)
//    {
//        Console.WriteLine(item);
//    }
//}


// 3. Calculates Primes
// I think using List is better since we do not know the number of primes inside the range

//static int[] FindPrimesInRange(int startNum, int endNum)
//{
//    int[] primes = new int[10];
//    int index = 0;
//    for (int i = startNum; i < endNum; i++)
//    {
//        Boolean prime = true;
//        for (int j = 2; j <= i / 2; j++)
//        {
//            if (i % j == 0)
//            {
//                prime = false;
//                break;
//            }
//        }

//        if (prime && i != 1)
//        {
//            primes[index] = i;
//            index++;
//        }
//    }
//    return primes;

//}
//int[] result = FindPrimesInRange(1, 10);
//foreach(int el in result)
//{
//    Console.Write(el + " ");
//}

// 4. Rotate and Sum

//int[] rotateSum(int[] array, int rotation)
//{
//    int[] sum = new int[array.Length];
//    Console.WriteLine("Array: [{0}]", string.Join(", ", array));
//    for (int c = 0; c < rotation; c++)
//    {
//        var temp = array[array.Length - 1];
//        for (int i = array.Length-1; i > 0; i--)
//        {
//            array[i] = array[i - 1];
//        }
//        array[0] = temp;


//        sum = sum.Zip(array,(x,y)=>x+y).ToArray<int>();
//    }

//    foreach(int num in sum)
//    {
//        Console.Write(num + " ");
//    }
//    return sum;

//}
//int[] array = { 3,2,4,-1 };
//rotateSum(array, 2);

//int[] aray = { 1, 2, 3, 4, 5 };
//rotateSum(aray, 3);

// 5. Longest Sequence of equal elements

//void longSeq(int[] array)
//{
//    int count = 1;
//    int longestNum = array[0];
//    int longestCount = 1;

//    for (int i = 1; i < array.Length; i++)
//    {
//        if (array[i] != array[i - 1])
//        {
//            count = 0;
//        }
//        count++;
//        if (count> longestCount)
//        {
//            longestCount = count;
//            longestNum = array[i];
//        }
//    }

//    Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));
//}
//int[] arr1 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
//longSeq(arr1);
//int[] arr2 = { 4, 4, 4, 4 };
//longSeq(arr2);

// 6. Most Frequent Number

//void mostFreq(int[] array)
//{
//    IDictionary<int, int> map = new Dictionary<int, int>();
//    int count;
//    int maxCount = 0;
//    int maxInt = int.MinValue;
//    int[] freqnums;
//    foreach (int i in array)
//    {
//        if(map.TryGetValue(i,out count)) // gets a value (at a key) from Dictionary
//        {
//            count++;
//            map[i] = count;
//        }
//        else
//        {
//            count = 1;
//            map.Add(i, count);
//        }
//        if (count>= maxCount)
//        {
//            maxInt = i;
//            maxCount = count;
//        }
//    }
//    Console.WriteLine($"most frequent number is {maxInt} with frequency of {maxCount}");


//}
//int[] arr1 = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
//mostFreq(arr1);
//int[] arr2 = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
//mostFreq(arr2);


// Practice String part 2

// 1. Reverse string
//string reverse1(string str)
//{
//    char[] charArr = str.ToCharArray();
//    Array.Reverse(charArr);
//    return new string(charArr);
    
//}

//string reverse2(string str)
//{
//    string res = String.Empty;
//    for (int i = str.Length-1; i >= 0; i--)
//    {
//        res += str[i];
//    }
//    return res;
//}

//string str1 = "sample";
//string str2 = "24tvcoi92";
//Console.WriteLine(reverse1(str1));
//Console.WriteLine(reverse2(str2));

// 2. Reverse the words (separators' location unchanged)
//string reverseStr(string str)
//{
//    string res = String.Empty;
//    char[] punctuation = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
//    char[] inputChars = str.ToCharArray();
//    string temp = "";
    
//    return "nope";
//}

//string sample = "C# is not C++, and PHP is not Delphi!";
//reverseStr(sample);
// 3. Extracts unique palindromes

//void findPalin(string str)
//{
//    char[] punctuation = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
//    string[] strlist = str.Split(punctuation);
//    List<string> palindromes = new List<string>();
//    foreach(string s in strlist)
//    {
//        if (isPalin(s)&&s!=String.Empty)
//        {
//            palindromes.Add(s);
//        }
//    }
//    palindromes.Sort();
//    Console.WriteLine(String.Join(", ", palindromes));
//}
//Boolean isPalin(string str)
//{
//    for(int i = 0; i< str.Length/2; i++)
//    {
//        if (str[i] != str[str.Length- i - 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}
//string str = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
//findPalin(str);

// 4. Parse an URL in the format: [protocol]://[server]/[resource]
// URI constructor is capable of parsing a URI

//void parseURL(string str)
//{
//    Uri url = new Uri(str);
//    Console.WriteLine($"[protocol] = {url.Scheme}");
//    Console.WriteLine($"[server] = {url.Host}");
//    Console.WriteLine($"[resrouce] = {url.PathAndQuery.Substring(1)}");
//}
//string url1 = "https://www.apple.com/iphone";
//parseURL(url1);

//string url2 = "ftp://www.example.com/employee";
//parseURL(url2);