using System;
using System.Numerics;
using System.Text.RegularExpressions;


Console.Write("Enter your favorite color: ");
string color = Console.ReadLine();

Console.Write("Enter your zodiac sign: ");
string sign = Console.ReadLine();

Console.Write("Enter your street address number: ");
string streetNum = Console.ReadLine();

Console.WriteLine($"Your hacker name is {color}{sign}{streetNum}.");




Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
Console.WriteLine($"byte: {sizeof(byte)} bytes, Min: {byte.MinValue}, Max: {byte.MaxValue}");
Console.WriteLine($"short: {sizeof(short)} bytes, Min: {short.MinValue}, Max: {short.MaxValue}");
Console.WriteLine($"ushort: {sizeof(ushort)} bytes, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
Console.WriteLine($"int: {sizeof(int)} bytes, Min: {int.MinValue}, Max: {int.MaxValue}");
Console.WriteLine($"uint: {sizeof(uint)} bytes, Min: {uint.MinValue}, Max: {uint.MaxValue}");
Console.WriteLine($"long: {sizeof(long)} bytes, Min: {long.MinValue}, Max: {long.MaxValue}");
Console.WriteLine($"ulong: {sizeof(ulong)} bytes, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
Console.WriteLine($"float: {sizeof(float)} bytes, Min: {float.MinValue}, Max: {float.MaxValue}");
Console.WriteLine($"double: {sizeof(double)} bytes, Min: {double.MinValue}, Max: {double.MaxValue}");
Console.WriteLine($"decimal: {sizeof(decimal)} bytes, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");



Console.Write("Enter number of centuries: ");
int centuries = int.Parse(Console.ReadLine());

int years = centuries * 100;
long days = (long)(years * 365.2425); // accounting for leap years
long hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
long milliseconds = seconds * 1000;
BigInteger microseconds = new BigInteger(milliseconds) * 1000;
BigInteger nanoseconds = microseconds * 1000;
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine("Fizz");
    else if (i % 5 == 0)
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(i);
}


int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}
//The byte (0–255) will overflow, causing an infinite loop.
/

Random rand = new Random();
int correctNumber = rand.Next(1, 4);

Console.Write("Guess a number between 1 and 3: ");
int guessedNumber = int.Parse(Console.ReadLine());

if (guessedNumber < 1 || guessedNumber > 3)
    Console.WriteLine("Out of range! Please enter 1, 2, or 3.");
else if (guessedNumber < correctNumber)
    Console.WriteLine("Too low!");
else if (guessedNumber > correctNumber)
    Console.WriteLine("Too high!");
else
    Console.WriteLine("Correct!");




int rows = 5;

for (int i = 1; i <= rows; i++)
{
    Console.Write(new string(' ', rows - i));
    Console.WriteLine(new string('*', i * 2 - 1));
}




Console.Write("Enter your birth date (YYYY-MM-DD): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
TimeSpan age = DateTime.Now - birthDate;

int daysOld = (int)age.TotalDays;
int daysToNextAnniversary = 10000 - (daysOld % 10000);
DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);

Console.WriteLine($"You are {daysOld} days old.");
Console.WriteLine($"Your next 10,000-day anniversary is on {nextAnniversary.ToShortDateString()}.");




DateTime now = DateTime.Now;
int hour = now.Hour;

if (hour >= 5 && hour < 12)
    Console.WriteLine("Good Morning");
if (hour >= 12 && hour < 17)
    Console.WriteLine("Good Afternoon");
if (hour >= 17 && hour < 21)
    Console.WriteLine("Good Evening");
if (hour >= 21 || hour < 5)
    Console.WriteLine("Good Night");



for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24; j += i)
    {
        Console.Write(j);
        if (j + i <= 24) Console.Write(",");
    }
    Console.WriteLine();
}




int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copiedArray = new int[originalArray.Length];

for (int i = 0; i < originalArray.Length; i++)
{
    copiedArray[i] = originalArray[i];
}

Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));





List<string> items = new List<string>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine();

    if (input == "--")
        items.Clear();
    else if (input.StartsWith("+"))
        items.Add(input.Substring(2));
    else if (input.StartsWith("-"))
        items.Remove(input.Substring(2));

    Console.WriteLine("Current List: " + string.Join(", ", items));
}




static bool IsPrime(int num)
{
    if (num < 2) return false;
    for (int i = 2; i * i <= num; i++)
        if (num % i == 0) return false;
    return true;
}

static int[] FindPrimesInRange(int start, int end)
{
    List<int> primes = new List<int>();
    for (int i = start; i <= end; i++)
        if (IsPrime(i))
            primes.Add(i);
    return primes.ToArray();
}



int[] arr = { 3, 2, 4, -1 };
int k = 2;
int n = arr.Length;
int[] sum = new int[n];

for (int r = 0; r < k; r++)
{
    int last = arr[n - 1];
    for (int i = n - 1; i > 0; i--)
        arr[i] = arr[i - 1];
    arr[0] = last;

    for (int i = 0; i < n; i++)
        sum[i] += arr[i];
}

Console.WriteLine("Sum: " + string.Join(" ", sum));




int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
int maxLen = 1, bestStart = 0, currLen = 1, start = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i - 1])
        currLen++;
    else
    {
        currLen = 1;
        start = i;
    }
    if (currLen > maxLen)
    {
        maxLen = currLen;
        bestStart = start;
    }
}

Console.WriteLine(string.Join(" ", arr[bestStart..(bestStart + maxLen)]));



Console.Write("Enter string: ");
string input = Console.ReadLine();

// Method 1: Using char array
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
Console.WriteLine(new string(charArray));

// Method 2: Using for loop
for (int i = input.Length - 1; i >= 0; i--)
    Console.Write(input[i]);


string sentence = "C# is not C++, and PHP is not Delphi!";
string[] words = Regex.Split(sentence, @"([ .,;=()&\[\]\""'\\/!?]+)");
Array.Reverse(words);
Console.WriteLine(string.Join("", words));


string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
string[] words = Regex.Split(text, @"\W+");
var palindromes = words.Where(w => w.Length > 1 && w.SequenceEqual(w.Reverse())).Distinct().OrderBy(w => w);
Console.WriteLine(string.Join(", ", palindromes));


string[] urls = {
            "https://www.apple.com/iphone",
            "ftp://www.example.com/employee",
            "https://google.com",
            "www.apple.com"
        };

foreach (var url in urls)
{
    string protocol = "", server = "", resource = "";

    int protocolEnd = url.IndexOf("://");
    int resourceStart = url.IndexOf("/", protocolEnd + 3);

    if (protocolEnd != -1)
    {
        protocol = url.Substring(0, protocolEnd);
        server = url.Substring(protocolEnd + 3, (resourceStart == -1 ? url.Length : resourceStart) - (protocolEnd + 3));
    }
    else
    {
        server = url.Substring(0, resourceStart == -1 ? url.Length : resourceStart);
    }

    if (resourceStart != -1)
        resource = url.Substring(resourceStart + 1);

    Console.WriteLine($"[protocol] = \"{protocol}\"\n[server] = \"{server}\"\n[resource] = \"{resource}\"\n");
}