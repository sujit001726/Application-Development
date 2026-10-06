class Program
{
    static void Main()
    {
        // 1. Create a DateTime for the birthdate
        DateTime birthDate = new DateTime(2004, 5, 20);

        // 2. Create a DateTime for the current date and time
        DateTime currentDate = DateTime.Now;

        // 3. Calculate age using TimeSpan
        TimeSpan age = currentDate - birthDate;
        int ageInYears = (int)(age.TotalDays / 365.25);

        // 4. Print birthdate, current date and age
        Console.WriteLine("Birthdate = " + birthDate.ToString("dd MMMM yyyy"));
        Console.WriteLine("Current date = " + currentDate.ToString("dd MMMM yyyy hh:mm tt"));
        Console.WriteLine("Age in years = " + ageInYears);

        // 5. Add 10 days to the birthdate
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days = " + newDate.ToString("dd MMMM yyyy"));
    }
}