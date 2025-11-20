// Removed all unnessecary ReadKey() from within the methods, and changed the method names to include the number in digits becuase it made it easier to 
// expand the list of methods and the cases in the swith statement.

using Microsoft.VisualBasic.FileIO;
using static System.Console;

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise1()
{
    string firstName = "Stefan", lastName = "Karlsson";

    WriteLine($"Hello {firstName} {lastName}! I’m glad to inform you that you are the test subject of my very first assignment!");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise2()
{
    Write("Firstname: ");
    string firstName = ReadLine();
    Write("Lastname: ");
    string lastName = ReadLine();

    Console.WriteLine($"Hello {firstName} {lastName}! Have a nice day!");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise4()
{
    DateTime date = DateTime.Now;

    WriteLine("Today in long date string: " + date.ToLongDateString());
    WriteLine("today in short date string: " + date.ToShortDateString());

    WriteLine($"Tomorrow: {date.AddDays(1).ToShortDateString()}");
    WriteLine($"Yesterday: {date.AddDays(-1).ToShortDateString()}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise9()
{
    // Area of Circle = r*r*PI       Area of Sphere = 4*r*r*PI

    Write("Radius: ");
    double radius = double.Parse(ReadLine()!);

    double areaOfCircle = Math.Pow(radius, 2) * Math.PI;
    double areaOfSphere = 4 * areaOfCircle;

    Console.WriteLine($"This would give a Circle area of {areaOfCircle:#.##}, and a Sphere area of {areaOfSphere:#.##}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise11()
{
    double temp;

    Write("Enter your body temperature in degrees Celsius: ");
    temp = double.Parse(ReadLine()!);

    if (temp < 37.5) WriteLine("No fever");
    else WriteLine("You have a fever");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise12()
{
    int year;

    Write("Enter current year: ");
    year = int.Parse(ReadLine()!);

    if (DateTime.Now.Year == year) WriteLine($"Yes that is right, the current year is {DateTime.Now.Year}");
    else WriteLine("No, that is not correct!");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise13()
{
    string op;
    double num1, num2;
    bool correctInput = false;

    // Input
    do
    {
        Write("Enter operator (+,-,* or /): ");
        op = ReadLine()!;

        correctInput = op switch
        {
            "+" => true,
            "-" => true,
            "*" => true,
            "/" => true,
            _ => false
        };
    } while (!correctInput);

    Write("Operand 1: ");
    num1 = double.Parse(ReadLine()!);

    Write("Operand 2: ");
    num2 = double.Parse(ReadLine()!);

    // Result
    switch (op)
    {
        case "+":
            WriteLine($"{num1} {op} {num2} = {num1 + num2}");
            break;
        case "-":
            WriteLine($"{num1} {op} {num2} = {num1 - num2}");
            break;
        case "*":
            WriteLine($"{num1} {op} {num2} = {num1 * num2}");
            break;
        case "/":
            WriteLine($"{num1} {op} {num2} = {num1 / num2}");
            break;
    }
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise14()
{
    Write("What is your grade? (A, B, C, D, E): ");
    string grade = ReadLine().ToUpper()!;

    switch (grade)
    {
        case "A":
            WriteLine($"A is an excellent grade!");
            break;
        case "B":
            WriteLine($"B is a good grade!");
            break;
        case "C":
            WriteLine($"C is a decent grade!");
            break;
        case "D":
            WriteLine($"D is not a very good grade!");
            break;
        case "E":
            WriteLine($"E is a really bad grade!");
            break;
        default:
            WriteLine($"That is not a grade!");
            break;
    }
    
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise15()
{
    int counter;

    Write("Enter a number below 100: ");
    int number = int.Parse(ReadLine()!);

    WriteLine();

    WriteLine("With a For-loop");
    for (int i = 1; i <= number; i++) Write($"{i} ");
    WriteLine();
    for (int i = number; i >= 1; i--) Write($"{i} ");
    
    WriteLine("\n");

    WriteLine("With a While-loop");
    counter = 1;
    while (counter <= number)
    {
        Write($"{counter} ");
        counter++;
    }
    WriteLine();
    counter = number;
    while (counter >= 1)
    {
        Write($"{counter} ");
        counter--;
    }

    WriteLine("\n");

    WriteLine("With a Do-While-loop");
    counter = 1;
    do
    {
        Write($"{counter} ");
        counter++;
    } while(counter <= number );
    WriteLine();
    counter = number;
    do
    {
        Write($"{counter} ");
        counter--;
    } while (counter >= 1);
    WriteLine("\n");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise16()
{
    DateTime now = DateTime.Now.Date;

    Write("Enter a date (yyyy-mm-dd): ");
    DateTime date = DateTime.Parse(ReadLine()!).Date;   // To be sure the time component is the same as in DateTime.Now.Date

    if (date == now) WriteLine($"{date.ToShortDateString()}: Present");
    else if (date < now) WriteLine($"{date.ToShortDateString()}: Past");
    else WriteLine($"{date.ToShortDateString()}: Future");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise17()
{
    // How to check for leap year: It has to be divisible by 4. If this year is divisible by 100, it has to be divisible by 400 to be a leap year.

    Write("Leap years: ");
    for(int year = 1990; year <= DateTime.Now.Year; year++)
    {
        if(year % 4 == 0)
        {
            if (year % 100 == 0 && year % 400 != 0) break;
            Write($"{year} ");
        }
    }
    WriteLine();
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise18()
{
    int secretNumber = new Random().Next(1, 11);
    int guess;

    do
    {
        Write("Guess a number (1 - 10): ");
        guess = int.Parse(ReadLine()!);

        if (guess == secretNumber)
        {
            WriteLine("Congratulations, you guess it!");
            break;
        }
        else
        {
            string answer;
            WriteLine("Sorry, wrong number!");
            
            do
            {
                Write("Do you want to guess again? (yes/no): ");
                answer = ReadLine()!.ToLower();
            } while(answer != "yes" && answer != "no");

            if (answer == "no") break;  
        }
    } while (true);
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise19()
{
    for(int i = 1; i <= 5; i++)
    {
        for (int j = 0; j <= i - 1; j++) Write(" ");
        for (int k = 1; k <= 6 - i; k++) Write("* ");
        WriteLine();
    }
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise20()
{
    double sum = 0, number = 0, noOfnumbers = 0;

    WriteLine("Finish by enter -1");

    while(true)
    {
        Write("Enter number: ");
        number = double.Parse(ReadLine()!);

        if (number == -1)
        {
            break;
        }
        else
        {
            noOfnumbers++;
            sum += number;
        }
    }

    WriteLine($"You entered {noOfnumbers} numbers. The sum was {sum:#.##} and the average {sum/noOfnumbers:#.##}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise21()
{
    // The Fibonacci series is a sequence of numbers where each number is the sum of the two preceding ones, typically starting with 0 and 1

    int last = 0, present = 1, max;

    Write("Shows the fibonacci series up until the following number: ");
    max = int.Parse(ReadLine()!);
    
    WriteLine();

    Write("0 ");
    while(true)
    {
        Write($"{present} ");
        int temp = last;
        last = present;
        present = temp + last;
        if (present > max) break;
    }
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise22()
{
    // Local functions 
    double AreaOfTriangle(double height, double width) => (height * width) / 2;

    // Main program
    WriteLine("This will calculate the area of a triangle");
    Write("Height: ");
    double height = double.Parse(ReadLine()!);
    Write("Width: ");
    double width = double.Parse(ReadLine()!);

    WriteLine($"Area: {AreaOfTriangle(height, width):#.##}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise23()
{
    // Overloading local functions does not work, so I have to declare them inside of a new Class, "Excercise23" at the bottom of this file.

    WriteLine("Enter 4 numbers");
    Write("Number 1: ");
    double num1 = double.Parse(ReadLine()!);
    Write("Number 2: ");
    double num2 = double.Parse(ReadLine()!);
    Write("Number 3: ");
    double num3 = double.Parse(ReadLine()!);
    Write("Number 4: ");
    double num4 = double.Parse(ReadLine()!);

    Excercise23.AddNumbers(num1, num2);
    Excercise23.AddNumbers(num1, num2, num3);
    Excercise23.AddNumbers(num1, num2, num3, num4);
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise24()
{
    // Local functions
    int GetLargestNumber(int[] values)    // Expect an array with at least one number
    {
        int temp = values[0];

        foreach (int number in values) if (number > temp) temp = number;

        return temp;
    }

    // Main program
    int[] numbers = [ 4, -5, 11, -88, 2 ];

    Write("Numbers: ");
    foreach (int number in numbers) Write($"{number} ");
    WriteLine($"\nThe largets number is {GetLargestNumber(numbers)}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise25()
{
    // Local functions
    void Swap(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;

        WriteLine($"Inside Swap: x = {x}, y = {y}");
    }

    // Main program
    int x = 5, y = 10;

    WriteLine($"Before Swap: x = {x}, y = {y}");
    Swap(x, y);
    WriteLine($"After Swap: x = {x}, y = {y}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise26()
{
    // Local functions
    void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;

        WriteLine($"Inside Swap: x = {x}, y = {y}");
    }

    // Main program
    int x = 5, y = 10;

    WriteLine($"Before Swap: x = {x}, y = {y}");
    Swap(ref x, ref y);
    WriteLine($"After Swap: x = {x}, y = {y}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise27()
{
    // I will not ignore white spaces or odd characters. All characters count.

    Write("Enter a word or sentence: ");
    string word = ReadLine()!.ToLower();

    bool isPalindrome = true;

    for(int i = 0; i <= word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }

    if (isPalindrome) WriteLine($"{word} is a palindrome");
    else WriteLine($"{word} is NOT a palindrome");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise28()
{
    // These arrays should get filled with the defaul value 0
    int[] numbers = new int[12];
    int[] odd = new int[12];
    int[] even = new int[12];

    // Get the numbers - no error checking
    WriteLine("Enter 12 positive integers");    
    for(int i = 0; i < numbers.Length; i++)
    {
        Write($"Number {i + 1}: ");
        numbers[i] = int.Parse(ReadLine());
    }

    // Sorting
    int oddIndex = 0, evenIndex = 0;

    foreach(int number in numbers)
    {
        if (number % 2 == 0) even[evenIndex++] = number;
        else odd[oddIndex++] = number;
    }
    WriteLine();

    // Output
    Write("All numbers: ");
    foreach (int number in numbers) Write($"{number} ");
    WriteLine();

    Write("Even numbers: ");
    for (int i = 0; i < evenIndex; i++) Write($"{even[i]} ");
    WriteLine();

    Write("Odd numbers: ");
    for (int i = 0; i < oddIndex; i++) Write($"{odd[i]} ");
    WriteLine();
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise29()
{
    int[] random = new int[10];
    int[] sorted = new int[10];

    Random dice = new();

    // Generate numbers
    for (int i = 0; i < random.Length; i++)
    {
        random[i] = dice.Next(1, 101);
    }

    // Sorting
    int front = 0, end = sorted.Length - 1;

    foreach (int number in random)
    {
        if (number % 2 == 0) sorted[front++] = number;
        else sorted[end--] = number;
    }

    // Output
    Write("Original: ");
    foreach (int number in random) Write($"{number} ");
    WriteLine();

    Write("Sorted: ");
    foreach (int number in sorted) Write($"{number} ");
    WriteLine();
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise30()
{
    Random dice = new();
    int[] numbers = new int[dice.Next(5, 16)];

    // Generating numbers
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = dice.Next(1, 101);
    }

    // Output unsorted list
    Write("Original: ");
    foreach (int number in numbers) Write($"{number} ");
    WriteLine();

    // Sorting with bubbelsort
    bool sorted;
    int temp;

    while (true)
    {
        sorted = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i-1])
            {
                temp = numbers[i - 1];
                numbers[i - 1] = numbers[i];
                numbers[i] = temp;
                sorted = false;
            }
        }
        if (sorted) break;
    }

    // Output sorted list
    Write("Sorted: ");
    foreach (int number in numbers) Write($"{number} ");
    WriteLine();
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise31()
{
    Random dice = new();
    int[] numbers = new int[dice.Next(1, 16)];

    // Creating array with no repeating numbers
    for(int i = 0; i < numbers.Length; i++)
    {
        int tmp = dice.Next(1, 100);
        bool exists = false;
        for (int j = 0; j < i; j++)
        {
            if (numbers[j] == tmp)
            {
                exists = true;
                break;
            }
        }

        if (exists) i--;
        else numbers[i] = tmp;
    }

    // Input
    int[] computed = new int[numbers.Length];
    int choice = 0;

    do
    {
        Write("Do you want squres(2) or cubes (3)?: ");
        choice = int.Parse(ReadLine()!);
    } while (choice != 2 && choice != 3);

    // Calculations
    for(int i = 0; i < numbers.Length; i++)
    {
        computed[i] = (int)Math.Pow(numbers[i], choice);
    }

    // Output
    Write("\nOriginal: ");
    foreach(int number in numbers) Write($"{number} ");
    Write("\nComputed: ");
    foreach (int number in computed) Write($"{number} ");
    WriteLine("\n");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise32()
{
    string numberString;
    string[] stringArray;
    int[] numbers;

    WriteLine("Enter numbers separated by commas (like 1,2,34,83,19,45): ");
    numberString = ReadLine()!;
    stringArray = numberString.Split(",", StringSplitOptions.TrimEntries);

    // Calculations
    int noOfNumbers = stringArray.Length;
    int sum = 0, min = int.MaxValue, max = int.MinValue;

    numbers = new int[noOfNumbers];

    for (int i = 0; i < stringArray.Length; i++)
    {
        numbers[i] = int.Parse(stringArray[i]);
    }

    foreach (int number in numbers)
    {
        sum += number;
        if (number < min) min = number;
        if (number > max) max = number;
    }

    // Output
    WriteLine($"Min: {min}     Max: {max}     Average: {((double)sum /noOfNumbers):#.##}");
}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise33()
{

}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise34()
{

}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise35()
{

}

// ----------------------------------------------------------------------------------------------------------------------------------------------

static void RunExercise36()
{

}

// ----------------------------------------------------------------------------------------------------------------------------------------------

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

// -------------------------------------------------------------- Classes -----------------------------------------------------------------------

class Excercise23
{
    public static void AddNumbers(double num1, double num2) => WriteLine($"{num1} + {num2} = {num1 + num2}");
    public static void AddNumbers(double num1, double num2, double num3) => WriteLine($"{num1} + {num2} + {num3} = {num1 + num2 + num3}");
    public static void AddNumbers(double num1, double num2, double num3, double num4) => WriteLine($"{num1} + {num2} + {num3} + {num4} = {num1 + num2 + num3 + num4}");
}