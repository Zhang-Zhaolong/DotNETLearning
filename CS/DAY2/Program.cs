using System;

using System.Collections.Generic;

//Working with methods


class Program1
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(20);
        PrintNumbers(numbers);
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


class Program2
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}



interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
}

interface IStudentService : IPersonService
{
    double CalculateGPA();
}

interface IInstructorService : IPersonService
{
    decimal CalculateBonus();
}

abstract class Person : IPersonService
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
    private List<string> Addresses = new List<string>();

    public int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public decimal CalculateSalary()
    {
        return Salary < 0 ? 0 : Salary;
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}

class Student : Person, IStudentService
{
    private Dictionary<string, char> Courses = new Dictionary<string, char>();

    public void EnrollCourse(string course, char grade)
    {
        Courses[course] = grade;
    }

    public double CalculateGPA()
    {
        double total = 0;
        foreach (var course in Courses)
        {
            total += GradeToPoints(course.Value);
        }
        return Courses.Count > 0 ? total / Courses.Count : 0;
    }

    private double GradeToPoints(char grade)
    {
        return grade switch
        {
            'A' => 4.0,
            'B' => 3.0,
            'C' => 2.0,
            'D' => 1.0,
            'F' => 0.0,
            _ => 0.0
        };
    }
}

class Instructor : Person, IInstructorService
{
    public DateTime JoinDate { get; set; }

    public decimal CalculateBonus()
    {
        int years = DateTime.Now.Year - JoinDate.Year;
        return years * 1000;
    }
}

class Program3
{
    static void Main(string[] args)
    {
        Student student = new Student { Name = "Alice", BirthDate = new DateTime(2000, 5, 15) };
        student.EnrollCourse("Math", 'A');
        student.EnrollCourse("Science", 'B');
        Console.WriteLine($"Student GPA: {student.CalculateGPA()}");

        Instructor instructor = new Instructor { Name = "Bob", BirthDate = new DateTime(1985, 3, 20), JoinDate = new DateTime(2010, 8, 1), Salary = 50000 };
        Console.WriteLine($"Instructor Salary: {instructor.CalculateSalary()}");
        Console.WriteLine($"Instructor Bonus: {instructor.CalculateBonus()}");
    }
}

class Color
{
    public int Red { get; private set; }
    public int Green { get; private set; }
    public int Blue { get; private set; }
    public int Alpha { get; private set; }

    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public int GetGrayscale()
    {
        return (Red + Green + Blue) / 3;
    }
}

class Ball
{
    public int Size { get; private set; }
    public Color BallColor { get; private set; }
    private int throwCount;

    public Ball(int size, Color color)
    {
        Size = size;
        BallColor = color;
        throwCount = 0;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}

class Program4
{
    static void Main(string[] args)
    {
        Color redColor = new Color(255, 0, 0);
        Color blueColor = new Color(0, 0, 255);

        Ball ball1 = new Ball(5, redColor);
        Ball ball2 = new Ball(10, blueColor);

        ball1.Throw();
        ball1.Throw();
        ball2.Throw();

        Console.WriteLine($"Ball 1 throw count: {ball1.GetThrowCount()}");
        Console.WriteLine($"Ball 2 throw count: {ball2.GetThrowCount()}");

        ball1.Pop();
        ball1.Throw();
        Console.WriteLine($"Ball 1 throw count after popping: {ball1.GetThrowCount()}");
    }
}
