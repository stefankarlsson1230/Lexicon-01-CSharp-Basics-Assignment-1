// Removed all unnessecary ReadKey() from within the methods, and changed the method names to include the number in digits

using static System.Console;

static void RunExercise1()
{

}

static void RunExercise2()
{
}

static void RunExercise3()
{

}
static void RunExercise4()
{

}

static void RunExercise5()
{

}

static void RunExercise6()
{

}

static void RunExercise7()
{

}

static void RunExercise8()
{

}

static void RunExercise9()
{

}

static void RunExercise10()
{

}

static void RunExercise11()
{
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


