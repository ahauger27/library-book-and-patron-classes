using System;

namespace library_book_and_patron_classes;

public partial class Patron
{
    private static int s_nextPatronNumber;
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public int PatronNumber { get; private set; }
    public bool IsBlocked { get; private set; } = false;
    public double ChargesOwed { get; private set; }
    static Patron()
    {
        Random random = new Random();
        s_nextPatronNumber = random.Next(10000000, 20000000);
    }

    public Patron(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        PatronNumber = s_nextPatronNumber++;
    }

    public void DisplayBasicPatronInfo()
    {
        Console.WriteLine("\n--- PATRON INFO ---");
        Console.WriteLine($"Full Name: {FirstName} {LastName}\nPatron Number: {PatronNumber}\nBlocked: {IsBlocked}\nBalance: ${ChargesOwed}");
    }


}