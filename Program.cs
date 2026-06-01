using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("JOB MARKET TRENDS ANALYSIS SYSTEM");

        Console.WriteLine("Enter Industry Type:");
        string industry = Console.ReadLine();

        Console.WriteLine("Enter Number of Vacancies:");
        int vacancies = Convert.ToInt32(Console.ReadLine());

        switch (industry)
        {
            case "IT":
                Console.WriteLine("Technology Industry Selected");
                break;

            case "Healthcare":
                Console.WriteLine("Healthcare Industry Selected");
                break;

            case "Finance":
                Console.WriteLine("Finance Industry Selected");
                break;

            default:
                Console.WriteLine("Unknown Industry");
                break;
        }

        if (vacancies >= 200)
        {
            Console.WriteLine("High Hiring Trend");
        }
        else if (vacancies >= 50)
        {
            Console.WriteLine("Moderate Hiring Trend");
        }
        else
        {
            Console.WriteLine("Low Hiring Trend");
        }

        Console.WriteLine("System Analysis Completed");
    }
}
