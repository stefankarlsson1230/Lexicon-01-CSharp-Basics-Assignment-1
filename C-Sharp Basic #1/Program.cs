// Removed all unnessecary ReadKey() from within the methods, and changed the method names to include the number in digits

using static System.Console;

static void RunExercise1()
{
    string firstName = "Stefan", lastName = "Karlsson";

    WriteLine($"Hello {firstName} {lastName}! I’m glad to inform you that you are the test subject of my very first assignment!");
}

static void RunExercise2()
{
    Write("Firstname: ");
    string firstName = ReadLine();
    Write("Lastname: ");
    string lastName = ReadLine();

    Console.WriteLine($"Hello {firstName} {lastName}! Have a nice day!");
}

static void RunExercise3()
{
    int num1, num2;

    try
    {
        Write("First number: ");
        num1 = int.Parse(ReadLine());

        Write("Second number: ");
        num2 = int.Parse(ReadLine());

        if (num1 + 1 == num2 || num1 - 1 == num2)
        {
            WriteLine("Consecutive");
        }
        else
        {
            WriteLine("Not consecutive");
        }
    }
    catch
    {
        ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Only enter numbers!!");
        ResetColor();
    }
}

static void RunExercise4()
{
    DateTime date = DateTime.Now;

    WriteLine("Today in long date string: " + date.ToLongDateString());
    WriteLine("today in short date string: " + date.ToShortDateString());

    WriteLine($"Tomorrow: {date.AddDays(1).ToShortDateString()}");
    WriteLine($"Yesterday: {date.AddDays(-1).ToShortDateString()}");
}

static void RunExercise5()
{
    //  Add any two integer numbers and store the sum result in a variable of type double.
    int int1 = 5;
    int int2 = 8;

    double sum1 = int1 + int2;
    WriteLine($"{int1} + {int2} = {sum1}");

    // Add any two decimal numbers (use variables of type double) and store the sum result in a variable of type integer.
    // If you get any error try to resolve it.
    double dec1 = 3.56;
    double dec2 = 2.23;
    
    int sum2 = Convert.ToInt32(dec1 + dec2);
    WriteLine($"{dec1} + {dec2} = {sum2} (rounded)");

    // Store an even number and an odd number in two different integer variables. Divide odd number by even number and
    // display an accurate result.
    int even = 2;
    int odd = 3;

    WriteLine($"{odd}/{even} = {(double)odd / even}");
}

static void RunExercise6()
{
    int x = 40;
    int y = 20;
    int z = 25;
    int m = 15;
    int e, f, g, h;

    e = (x + y) * z / m;    // 100
    WriteLine($"({x} + {y}) * {z} / {m} = {e}"); 

    f = (x + y) * (z / m);  // 60
    WriteLine($"({x} + {y}) * ({z} / {m}) = {f}");

    g = x + y * z / m;      // 73
    WriteLine($"{x} + {y} * {z} / {m} = {g}");

    h = (x + y * z) / m;    // 36
    WriteLine($"({x} + {y} * {z}) / {m} = {h}");
}

static void RunExercise7()
{
    Write("Enter a positive integer: ");
    int number = int.Parse(ReadLine()!);

    if (number % 2 == 0)
    {
        WriteLine($"{number} is even");
    }
    else
    {
        WriteLine($"{number} is odd");
    }
}

static void RunExercise8()
{
    List<int> masterList = new();
    List<int> odd = new();
    List<int> even = new();
    Random die = new();

    // Generate numbers 0-99
    for(int i = 1; i <= 20; i++)
    {
        masterList.Add(die.Next(100));
    }

    // Separate numbers
    foreach(int number in masterList)
    {
        if (number % 2 == 0) even.Add(number);
        else odd.Add(number);
    }

    // Show result
    Write("All numbers: ");
    foreach (int number in masterList) Write($"{number} ");
    WriteLine();

    Write("Even numbers: ");
    foreach (int number in even) Write($"{number} ");
    WriteLine();

    Write("Odd numbers: ");
    foreach (int number in odd) Write($"{number} ");
    WriteLine();
}

static void RunExercise9()
{
    // Area of Circle = r*r*PI       Area of Sphere = 4*r*r*PI

    Write("Radius: ");
    double radius = double.Parse(ReadLine()!);

    double areaOfCircle = Math.Pow(radius, 2) * Math.PI;
    double areaOfSphere = 4 * areaOfCircle;

    Console.WriteLine($"This would give a Circle area of {areaOfCircle:#.##}, and a Sphere area of {areaOfSphere:#.##}");
}

static void RunExercise10()
{
    double[] numbers = new double[10];

    WriteLine("Enter 10 numbers.");

    // Input
    for(int i = 0; i < numbers.Length; i++)
    {
        Write($"Number {i+1}: ");
        numbers[i] = double.Parse(ReadLine()!);
    }

    // Output
    Write("Negative numbers: ");
    foreach(double number in numbers)
    {
        if (number < 0) Write($"{number} ");
    }
    WriteLine();
}

static void RunExercise11()
{
    double temp;

    Write("Enter your body temperature in degrees Celsius: ");
    temp = double.Parse(ReadLine()!);

    if (temp < 37.5) WriteLine("No fever");
    else WriteLine("You have a fever");
}

static void RunExercise12()
{
}

static void RunExercise13()
{

}
static void RunExercise14()
{

}

static void RunExercise15()
{

}

static void RunExercise16()
{

}

static void RunExercise17()
{

}

static void RunExercise18()
{

}

static void RunExercise19()
{

}

static void RunExercise20()
{

}

static void RunExercise21()
{
}

static void RunExercise22()
{
}

static void RunExercise23()
{

}
static void RunExercise24()
{

}

static void RunExercise25()
{

}

static void RunExercise26()
{

}

static void RunExercise27()
{

}

static void RunExercise28()
{

}

static void RunExercise29()
{

}

static void RunExercise30()
{

}

static void RunExercise31()
{

}

static void RunExercise32()
{

}

static void RunExercise33()
{

}
static void RunExercise34()
{

}

static void RunExercise35()
{

}

static void RunExercise36()
{

}


bool keepAlive = true;
while (keepAlive)
{
    try
    {
        Write("Enter assignment number (or -1 to exit): ");
        var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
        ForegroundColor = ConsoleColor.Green;
        switch (assignmentChoice)
        {
            case 1:
                RunExercise1();
                break;
            case 2:
                RunExercise2();
                break;
            case 3:
                RunExercise3();
                break;
            case 4:
                RunExercise4();
                break;
            case 5:
                RunExercise5();
                break;
            case 6:
                RunExercise6();
                break;
            case 7:
                RunExercise7();
                break;
            case 8:
                RunExercise8();
                break;
            case 9:
                RunExercise9();
                break;
            case 10:
                RunExercise10();
                break;
            case 11:
                RunExercise11();
                break;
            case 12:
                RunExercise12();
                break;
            case 13:
                RunExercise13();
                break;
            case 14:
                RunExercise14();
                break;
            case 15:
                RunExercise15();
                break;
            case 16:
                RunExercise16();
                break;
            case 17:
                RunExercise17();
                break;
            case 18:
                RunExercise18();
                break;
            case 19:
                RunExercise19();
                break;
            case 20:
                RunExercise20();
                break;
            case 21:
                RunExercise21();
                break;
            case 22:
                RunExercise22();
                break;
            case 23:
                RunExercise23();
                break;
            case 24:
                RunExercise24();
                break;
            case 25:
                RunExercise25();
                break;
            case 26:
                RunExercise26();
                break;
            case 27:
                RunExercise27();
                break;
            case 28:
                RunExercise28();
                break;
            case 29:
                RunExercise29();
                break;
            case 30:
                RunExercise30();
                break;
            case 31:
                RunExercise31();
                break;
            case 32:
                RunExercise32();
                break;
            case 33:
                RunExercise33();
                break;
            case 34:
                RunExercise34();
                break;
            case 35:
                RunExercise35();
                break;
            case 36:
                RunExercise36();
                break;

            case -1:
                keepAlive = false;
                break;
            default:
                ForegroundColor = ConsoleColor.Red;
                WriteLine("That is not a valid assignment number!");
                break;
        }
        ResetColor();
        WriteLine("Hit any key to continue..");
        ReadKey();
        Clear();
    }
    catch (Exception e)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(e.Message);
        ResetColor();
    }
}


