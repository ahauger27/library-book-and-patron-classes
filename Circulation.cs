using System;

namespace library_book_and_patron_classes;

public static class Circulation
{
    public static void CheckOutItem(Item item, Patron patron)
    {
        ItemProcessingMessage();

        if (item.IsCheckedOut)
        {
            Console.WriteLine($"The item #{item.ItemNumber} could not be checked out.");
            Console.WriteLine($"The item is already checked out.");
        }
        else if (patron.IsBlocked)
        {
            Console.WriteLine($"The item #{item.ItemNumber} could not be checked out.");
            Console.WriteLine($"Patron #{patron.PatronNumber} is 'BLOCKED'.");
        }
        else if (item.IsLost)
        {
            Console.WriteLine($"The item #{item.ItemNumber} could not be checked out.");
            Console.WriteLine($"The item is marked 'LOST'.");
        }
        else
        {
            item.CurrentBorrower = patron.PatronNumber;
            item.IsCheckedOut = true;
            Console.WriteLine($"The item #{item.ItemNumber} has been successfully checked out to Patron #{patron.PatronNumber}.");
        }
    }

    public static void ReturnItem(Item item)
    {
        ItemProcessingMessage();

        if (!item.IsCheckedOut)
        {
            Console.WriteLine($"The item #{item.ItemNumber} is already 'IN'.");
        }
        else
        {
            item.CurrentBorrower = 0;
            item.IsCheckedOut = false;
            Console.WriteLine($"The item #{item.ItemNumber} has been marked 'IN'.");
        }
    }

    public static void MarkAsLost(Item item, Patron patron)
    {
        ItemProcessingMessage();
        
        Console.WriteLine($"The item '{item.Title}' has been marked as 'LOST'.");
        patron.ApplyCharge(item.FineAmount);
        item.IsLost = true;
    }

    public static void ItemProcessingMessage()
    {
        Console.WriteLine("\n--- ITEM PROCESSING ---");
    }
}