using System;

namespace library_book_and_patron_classes;

public static class Circulation
{
    public static void CheckOutItem(Item item, Patron patron)
    {
        if (item.IsCheckedOut || patron.IsBlocked || item.IsLost)
        {
            Console.WriteLine($"\nThe item {item.ItemNumber} could not be checked out.");
        }
        else if (item.IsCheckedOut)
        {
            Console.WriteLine($"\nThe item {item.ItemNumber} is already checked out.");
        }
        else
        {
            item.CurrentBorrower = patron.PatronNumber;
            item.IsCheckedOut = true;
            Console.WriteLine($"\nThe item {item.ItemNumber} has been successfully checked out.");
        }
    }

    public static void ReturnItem(Item item)
    {
        if (!item.IsCheckedOut)
        {
            Console.WriteLine($"\nThe item {item.ItemNumber} is already 'IN'.");
        }
        else
        {
            item.CurrentBorrower = 0;
            item.IsCheckedOut = false;
            Console.WriteLine($"\nThe item {item.ItemNumber} has been marked 'IN'.");
        }
    }

    


}