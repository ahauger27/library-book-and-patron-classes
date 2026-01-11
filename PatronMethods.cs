using System;

namespace library_book_and_patron_classes;

public partial class Patron
{
        public void DisplayCharges()
    {
        Console.WriteLine("\n--- PATRON CHARGES ---");
        Console.WriteLine($"Patron #{PatronNumber} owes ${ChargesOwed}.");
        Console.WriteLine(IsBlocked ? "STATUS: 'BLOCKED'" : "STATUS: 'GOOD STANDING'.");
    }

    public void ApplyCharge(double charge)
    {
        FineProcessingMessage();
        
        ChargesOwed += charge;
        Console.WriteLine($"A charge of ${charge} has been applied to Patron #{PatronNumber}. Current balance is ${ChargesOwed}.");
        if (ChargesOwed >= 50.00)
        {
            IsBlocked = true;
            Console.WriteLine($"Patron #{PatronNumber} has been 'BLOCKED' due to outstanding charges of ${ChargesOwed}.");
        }
    }

    public void PayCharge(double payment)
    {
        FineProcessingMessage();

        ChargesOwed -= payment;
        Console.WriteLine($"A payment of ${payment} has been applied to Patron #{PatronNumber}. Current balance is ${ChargesOwed}.");
        if (ChargesOwed < 50.00)
        {
            IsBlocked = false;
            Console.WriteLine($"Patron #{PatronNumber} is in 'GOOD STANDING'.");
        }
    }

    public void FineProcessingMessage()
    {
        Console.WriteLine("\n--- PROCESSING FINES ---");
    }

}
