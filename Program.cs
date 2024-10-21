using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        int Grade = int.Parse(Console.ReadLine());

        if (Grade >= 100)
    {
        Console.WriteLine("Letter Grade: A+");
        Console.WriteLine("Message: Wow! 100…That’s impressive!");
    }
    else if (Grade >= 90)
    {
        Console.WriteLine("Letter Grade: A");
        Console.WriteLine("Very nice!");
    }
    else if (Grade >= 80)
    {
        Console.WriteLine("Letter Grade: B");
        Console.WriteLine("Keep it up!");
    }
    else if (Grade >= 70)
    {
        Console.WriteLine("Letter Grade: C");
        Console.WriteLine("You got this, keep working!");
    }
    
    else if (Grade >= 60)
    {
        Console.WriteLine("Letter Grade: D");
        Console.WriteLine("Keep trying!");
    }
    else
    {
        Console.WriteLine("Letter Grade: E");
        Console.WriteLine("Don't give up!");
    }

    }
}