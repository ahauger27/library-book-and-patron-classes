using System;

namespace library_book_and_patron_classes;

public class Item
{
    private static int s_nextItemNumber;
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int ItemNumber { get; private set; }
    public string Format { get; set; } = "";
    public string Collection { get; set; } = "";
    public bool IsCheckedOut { get; set; } = false;
    public bool IsLost { get; private set; } = false;
    public double FineAmount { get; private set; }
    public int CurrentBorrower { get; set; }

    static Item()
    {
        Random random = new Random();
        s_nextItemNumber = random.Next(000001, 1000000);
    }

    public Item(string title, string author, string format, string collection, double fineAmount = 15.00)
    {
        Title = title;
        Author = author;
        Format = format;
        Collection = collection;
        FineAmount = fineAmount;
        ItemNumber = s_nextItemNumber++;
    }

    public string DisplayBookInfo()
    {
        return $"\nTitle: {Title}\nAuthor: {Author}\nItem Number: {ItemNumber}\nFormat: {Format}\nCollection: {Collection}\nChecked Out: {IsCheckedOut}";
    }

    public void MarkAsLost(Patron patron)
    {
        Console.WriteLine($"\nThe item '{Title}' has been marked as 'LOST'. A fine of ${FineAmount} has been charged to Patron #{patron.PatronNumber}.");
        patron.ApplyCharge(FineAmount);
        IsLost = true;
    }

    public void CheckedOutTo(Item item, Patron patron)
    {
        item.CurrentBorrower = patron.PatronNumber;
    }
}
