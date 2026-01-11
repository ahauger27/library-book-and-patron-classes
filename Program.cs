using library_book_and_patron_classes;

Patron patron01 = new Patron("John", "Doe");
Patron patron02 = new Patron("Jane", "Smith");
Patron patron03 = new Patron("Anthony", "Smith");
Patron patron04 = new Patron("Emily", "Johnson");
Patron patron05 = new Patron("Michael", "Brown");


patron03.ApplyCharge(60.00);

patron01.DisplayBasicPatronInfo();
patron02.DisplayBasicPatronInfo();
patron03.DisplayBasicPatronInfo();

Item book01 = new Item("The Two Towers", "J.R.R. Tolkien", "Paperback", "Fiction");
Item book02 = new Item("The Midnight Library", "Matt Haig", "Hardcover", "Fiction");
Item book03 = new Item("107 Days", "Kamala Harris", "Book", "Biography", fineAmount: 25.00);
Item book04 = new Item("The Hobbit", "J.R.R. Tolkien", "Hardcover", "Fiction", fineAmount: 20.00);
Item book05 = new Item("Becoming", "Michelle Obama", "Audiobook", "Biography", fineAmount: 30.00);
Item book06 = new Item("1984", "George Orwell", "Hardcover", "Fiction", fineAmount: 25.00, isLost: true);


book01.DisplayBookInfo();
book02.DisplayBookInfo();
book03.DisplayBookInfo();
book04.DisplayBookInfo();
book05.DisplayBookInfo();
book06.DisplayBookInfo();

Circulation.CheckOutItem(book01, patron01);
Circulation.CheckOutItem(book02, patron03);
Circulation.CheckOutItem(book02, patron02);
Circulation.CheckOutItem(book04, patron05);
Circulation.CheckOutItem(book05, patron04);
Circulation.CheckOutItem(book06, patron01);

Circulation.ReturnItem(book01);

Circulation.MarkAsLost(book01, patron02);
patron02.DisplayCharges();
patron02.PayCharge(15.00);

