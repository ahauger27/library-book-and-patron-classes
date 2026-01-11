using System;

namespace library_book_and_patron_classes;

public class Patron
{
    private static int s_nextPatronNumber;
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public int PatronNumber { get; private set; }
    public bool IsBlocked { get; set; } = false;
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
        Console.WriteLine($"\nFull Name: {FirstName} {LastName}\nPatron Number: {PatronNumber}\nBlocked: {IsBlocked}\nBalance: ${ChargesOwed}");
    }

    public string DisplayCharges()
    {
        return $"\nPatron # {PatronNumber} | Balance: ${ChargesOwed}";
    }

    public void ApplyCharge(double charge)
    {
        ChargesOwed = charge;
        if (ChargesOwed >= 50.00)
        {
            IsBlocked = true;
            Console.WriteLine($"\nPatron #{PatronNumber} has been 'BLOCKED' due to outstanding charges of ${ChargesOwed}.");
        }
    }

    public void PayCharge(double payment)
    {
        ChargesOwed -= payment;
        if (ChargesOwed < 50.00)
        {
            IsBlocked = false;
            Console.WriteLine($"\nPatron #{PatronNumber} has been unblocked. Current balance is ${ChargesOwed}.");
        }
    }
}