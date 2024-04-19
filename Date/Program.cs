internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a date (MM/DD/YYYY):");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
        {
            string season = GetSeason(inputDate);
            string dayOfWeek = inputDate.ToString("dddd");
            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Error: Invalid date format.");
        }
    }

    static string GetSeason(DateTime date)
    {
        int month = date.Month;
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Unknown";
        }
    }
}