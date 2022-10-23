using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

internal class Program
{
    static void Main()
    {
        //first two lines are the title and subtitle
        Console.WriteLine("Academy Of Learning Career College \nStudent Dailyy Report");
        //Question A.
        Console.WriteLine("What is your name?");
        string Name = Console.ReadLine();
        //Question B 
        Console.WriteLine("What course are you on?");
        string Course = Console.ReadLine();
        //Question C
        Console.WriteLine("What page Number?");
        string pageNum = Console.ReadLine();
        //Save page number with Integer data type
        int pageNumInt = Convert.ToInt32(pageNum);
        //Question D
        Console.WriteLine("Do you need help with anything? please answer \"true\" or \"false\"");
        string needHelp = Console.ReadLine();
        //Save true or false answer as a boolean
        bool needHelpBool = Convert.ToBoolean(needHelp);
        //Question E
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string Experience = Console.ReadLine();
        //question F
        Console.WriteLine("is there any other feedback you'd like to provide? please be specific.");
        string feedback = Console.ReadLine();
        //Question G
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        //Save Hours studied as decimals
        decimal hoursStudiedShort = Convert.ToDecimal(hoursStudied);
        //Message after questions
        Console.WriteLine("Thank you for your answers. \nAn instructor will reapond shortly. \n Have a great day!");
        Console.ReadLine();

    }
}

