// See https://aka.ms/new-console-template for more information

using static System.Console;

static void RunExerciseOne()
{
    WriteLine("Write your own code for this method. Press any key to exit method.");
    ReadKey();
}

static void RunExerciseTwo()
{
    ReadKey();
}

static void RunExerciseThree()
{
    ReadKey();
}
static void RunExerciseFour()
{
    ReadKey();
}

static void RunExerciseFive()
{
    ReadKey();
}

static void RunExerciseSix()
{
    ReadKey();
}

static void RunExerciseSeven()
{
    ReadKey();
}

static void RunExerciseEight()
{
    ReadKey();
}

static void RunExerciseNine()
{
    ReadKey();
}

static void RunExerciseTen()
{
    ReadKey();
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
                RunExerciseOne();
                break;
            case 2:
                RunExerciseTwo();
                break;
            case 3:
                RunExerciseThree();
                break;
            case 4:
                RunExerciseFour();
                break;
            case 5:
                RunExerciseFive();
                break;
            case 6:
                RunExerciseSix();
                break;
            case 7:
                RunExerciseSeven();
                break;
            case 8:
                RunExerciseEight();
                break;
            case 9:
                RunExerciseNine();
                break;
            case 10:
                RunExerciseTen();
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

