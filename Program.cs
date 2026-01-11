// See https://aka.ms/new-console-template for more information
using library_book_and_patron_classes;

Patron patron01 = new Patron("John", "Doe");
Patron patron02 = new Patron("Jane", "Smith");
Patron patron03 = new Patron("Anthony", "Smith");


patron03.IsBlocked = true;

// patron01.DisplayBasicPatronInfo();
// patron02.DisplayBasicPatronInfo();
// patron03.DisplayBasicPatronInfo();

Item book01 = new Item("The Two Towers", "J.R.R. Tolkien", "Paperback", "Fiction");
Item book02 = new Item("The Midnight Library", "Matt Haig", "Book", "Fiction");
Item book03 = new Item("107 Days", "Kamala Harris", "Book", "Biography", fineAmount: 25.00);

Console.WriteLine(book01.DisplayBookInfo());
Console.WriteLine(book02.DisplayBookInfo());
Console.WriteLine(book03.DisplayBookInfo());


Circulation.CheckOutItem(book01, patron01);
Circulation.CheckOutItem(book02, patron03);
Circulation.CheckOutItem(book02, patron02);

Circulation.ReturnItem(book01);

book02.MarkAsLost(patron02);

// patron01.ApplyCharge(book01.FineAmount);
// Console.WriteLine(patron01.DisplayCharges());