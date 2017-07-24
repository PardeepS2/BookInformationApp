using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class Program
    {
        static bool run = true;
        static int choice =0;

        static void Main(string[] args)
        {
           
            User user = new User();

            FillData(user);

            while(run)
            {
                Menu(user);
            }
        }

        static void Menu(User user)
        {
           
            Console.Clear();
            Console.WriteLine("\tWelCome To The Book Infomation Application");
            Console.WriteLine("\t=========================================");
            Console.WriteLine();
            Console.WriteLine("\t1. List of Available Books");
            Console.WriteLine("\t2. List of Authors");
            Console.WriteLine("\t3. Shop Books");
            Console.WriteLine("\t4. Search Books by Book name");
            Console.WriteLine("\t5. Checkout");
           // Console.WriteLine("\t5. Search Books by Name of the Author ");
            Console.WriteLine("\t6. Exit program\n");
            Console.WriteLine("\tPlease select from the options:");
            choice = Convert.ToInt32(Console.ReadLine());

            
            if (choice == 1)
            {
                AvailableBooks(user);
            }

            else if (choice == 2)
            {
                AvailableAuthors(user);
            }

            else if (choice == 3)
            {
                BuyBooks(user);
            }

            else if (choice == 4)
            {
                SearchBookName(user);
            }

            else if (choice == 5)
            {
                CheckOut(user);
            }

            else if (choice== 6)
            {
                Environment.Exit(0);
            }
        }

        static void FillData(User user)
        {
            Author author1 = new Author("tom  ", "tom@gmail.com", 'M');
            Author author2 = new Author("mandeep", "man@gmail.com", 'F');
            Author author3 = new Author("pardeep", "par@gmail.com", 'M');
            Author author4 = new Author("reza  ", "raz@gmail.com", 'M');
            Author author5 = new Author("kiran  ", "kiran@gmail.com", 'M');
            Author author6 = new Author("Julie", "julie@gmail.com", 'F');

            user.AddAuthor(author1);
            user.AddAuthor(author2);
            user.AddAuthor(author3);
            user.AddAuthor(author4);
            user.AddAuthor(author5);
            user.AddAuthor(author6);

            user.AddBook(new Book("musketers", new Author[] { author6, author5 }, 0, new Date(22, 11, 2002), 15));
            user.AddBook(new Book("five p", new Author[] { author2, author3 }, 11.45, new Date(23, 10, 2012), 16));
            user.AddBook(new Book("soul  ", new Author[] { author4, author6 }, 34.22, new Date(05, 07, 2001), 14));
            user.AddBook(new Book("3 mist", new Author[] { author3, author1 }, 22.01, new Date(09, 09, 2002), 19));
            user.AddBook(new Book("wrath", new Author[] { author3, author5 }, 10.50, new Date(13, 06, 2011),50));
            user.AddBook(new Book("dunken", new Author[] { author2, author4 }, 21.01, new Date(25, 08, 2003), 14));
            user.AddBook(new Book("blue  ", new Author[] { author1, author3 }, 19.11, new Date(17, 03, 2014), 32));
            user.AddBook(new Book("ocean", new Author[] { author6, author2 }, 10.11, new Date(11, 01, 2011), 27));
            user.AddBook(new Book("summer", new Author[] { author4, author1 }, 23.00, new Date(02, 05, 2011), 10));
            user.AddBook(new Book("silence", new Author[] { author5, author3 }, 12.01, new Date(16, 05, 2017), 90));
            user.AddBook(new Book("nightingale", new Author[] { author3, author6 }, 17.15, new Date(17, 05, 2005), 75));
            user.AddBook(new Book("town", new Author[] { author4, author1 }, 19.25, new Date(19, 06, 2013), 55));
            user.AddBook(new Book("nightmare", new Author[] { author1, author5 }, 13.90, new Date(14, 12, 2014), 88));
            user.AddBook(new Book("mosaic", new Author[] { author1, author4 }, 40.32, new Date(16, 03, 2010), 50));
            user.AddBook(new Book("devil", new Author[] { author2, author6 }, 39.25, new Date(17, 05, 2017), 96));
            user.AddBook(new Book("wrinkle", new Author[] { author3, author4 }, 30.00, new Date(22, 11, 2014), 90));
            user.AddBook(new Book("dumb  ", new Author[] { author5, author2 }, 26.10, new Date(23, 07, 2013), 30));
            user.AddBook(new Book("duster", new Author[] { author6, author4 }, 45.05, new Date(21, 03, 1998), 55));
            user.AddBook(new Book("romeo", new Author[] { author5, author3 }, 69.50, new Date(29, 02, 2001), 66));
            user.AddBook(new Book("angela", new Author[] { author1, author2 }, 56.03, new Date(23, 06, 2014), 100));
            
        }

        static void AvailableBooks(User user)
        {
            Console.Clear();
            Book[] Books = user.GetBook();

            Console.WriteLine("\t\tList of all available books");
            Console.WriteLine("\t\t===========================");
            Console.WriteLine();
            Console.WriteLine("  BookName\t\tPrice\t\tQuantity");
            Console.WriteLine();
            for (int i = 0; i < Books.Length; i++)
            {
                
                
                double price = Books[i].GetPrice();
                if (price <= 0 )
                {

                    Console.WriteLine(i + 1 + ". " + Books[i].GetName() + "\t\t" + "free" + "\t\t " + Books[i].GetQty());


                }
                else
                    Console.WriteLine(i + 1 + ". " + Books[i].GetName() + "\t\t$" + Books[i].GetPrice() + "\t\t " + Books[i].GetQty());
            }
            //Console.WriteLine("Press any key for main menu");
            //Console.ReadKey();
            Console.WriteLine("Press 1 to buy books:");
            Console.WriteLine("Press 2 to Main Menu:");
            choice = Convert.ToInt32(Console.ReadLine());
            

            if(choice == 1)
            {
                BuyBooks(user);               
            }   else if (choice == 2)
            {
                Menu(user);
            }        
        }

        static void AvailableAuthors(User user)
        {
            Console.Clear();
            Author[] allAuthors = user.GetAuthors();

            Console.WriteLine("\tList of all available authors");
            Console.WriteLine("\t=============================");
            Console.WriteLine();
            Console.WriteLine("  AuthorName\t\tEmail\t\t\tGender\n");
            for (int i = 0; i < allAuthors.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + allAuthors[i].GetName() + "\t\t" + allAuthors[i].GetEmail() + "\t\t" + allAuthors[i].GetGender());
            }
            Console.WriteLine("\nPress any key for main menu");
            Console.ReadKey();
        }

        static void BuyBooks(User user)
        {
            Console.Clear();
            Book[] books = user.GetBook();

            int select = 0;
            int qty;
            int nqty = 0;

            Console.WriteLine("\n\t\tList of available books");
            Console.WriteLine("\t\t=======================");
            Console.WriteLine("\tBooks\t\tAuthors\t\tQuantity\n");
            for (int i = 0; i < books.Length; i++)
            {
                Book b = new Book();
                b = books[i];
                Console.Write("\t" + (i + 1) + ". " + b.GetName());
                if(b.GetPrice() <= 0)
                {
                    
                    Console.Write("\t" + "free");
           }else
                {
                    Console.Write("\t$" + b.GetPrice());
                }
                
                Console.WriteLine("\t\t" + b.GetQty() + " books available");
            }

            Console.WriteLine("\nSelect which book you want to buy");
            select = Convert.ToInt32(Console.ReadLine());
            do {
                Console.WriteLine("\nEnter No of books you want to buy");
                qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("No of book should be more then zero");
            }
            while (qty<=0);
                 
            for (int i = 0; i < books.Length; i++)
            {
                if (i == select - 1)
                {
                    Book bc = new Book();
                    bc = books[i];

                    nqty = books[i].GetQty();
                   
                    books[i].SetQty(nqty - qty);

                    bc.SetQty(qty);

                    user.AddToCart(bc);
                    Console.WriteLine("Book added to cart");
                }
            }

            Console.Clear();

            Console.WriteLine("\tSelect option\n");
            Console.WriteLine("1. Remove book from the shopping cart");
            Console.WriteLine("2. Go to main menu");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. Exit");

            int submenu = 0;
            submenu = Convert.ToInt32(Console.ReadLine());

            switch (submenu)
            {
                case 1:
                    Book[] cartBooks = user.GetShoppingCart();

                    int s = 0;

                    Console.WriteLine("\n\t\tList of books in cart\n");

                    for (int i = 0; i < cartBooks.Length; i++)
                    {
                        Book b = new Book();
                        b = cartBooks[i];
                        Console.Write("\t" + (i + 1) + ". " + b.GetName());
                        Console.Write("\t$" + b.GetPrice());
                        Console.WriteLine("\t" + b.GetQty() + " books ");
                    }

                    Console.WriteLine("\nSelect which book you want to remove from cart");
                    s = Convert.ToInt32(Console.ReadLine());
                    string bookname;
                    for (int i = 0; i < cartBooks.Length; i++)
                    {
                        if (i == s - 1)
                        {
                            bookname = cartBooks[i].GetName();
                            nqty = cartBooks[i].GetQty();

                            for (int j = 0; j < books.Length; j++)
                            {
                                if (books[j].GetName().Equals(bookname))
                                {
                                    books[j].SetQty(nqty + cartBooks[i].GetQty());
                                }
                            }

                            user.RemoveFromCart(cartBooks[i]);
                            Console.WriteLine("The selected book removed from the shopping cart!");
                        }
                    }

                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Book[] cart = user.GetShoppingCart();
                    double bill = 0;

                    Console.WriteLine("\n\t\tList of books in cart\n");

                    for (int i = 0; i < cart.Length; i++)
                    {
                        Book b1 = new Book();
                        b1 = cart[i];
                        Console.Write("\t" + (i + 1) + ". " + b1.GetName());
                        Console.Write("\t$" + b1.GetPrice());
                        Console.WriteLine("\t" + b1.GetQty() + " books");
                    }

                    for (int i = 0; i < cart.Length; i++)
                    {
                        Book b2 = new Book();
                        b2 = cart[i];
                        bill += b2.GetQty() * b2.GetPrice();
                    }

                    Console.WriteLine("Your bill is $" + bill);
                    Console.ReadKey();
                    for (int i = 0; i < cart.Length; i++)
                    {
                        Book b = new Book();
                        b = cart[i];
                        user.RemoveFromCart(cart[i]);
                    }
                    Console.Clear();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
            Console.Clear();
        }

        static void ShoopBooks(User user)
        {
            Console.Clear();
            Book[] books = user.GetBook();

            string book;

            Console.WriteLine("Enter book name");
            book = Console.ReadLine();

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].GetName().Equals(book))
                {
                    Author[] a = books[i].GetAuthors();
                    string name = "\t";
                    for (int j = 0; j < a.Length; j++)
                    {
                        name += a[j].GetName() + " ";
                    }

                    Console.WriteLine(books[i].GetName() + name + "\t\t$" + books[i].GetPrice());
                }
            }
            Console.ReadKey();
        }

        static void SearchBookName(User user)
        {
            Console.Clear();
            Book[] books = user.GetBook();

            string book;

            Console.WriteLine("Please Enter a book name");
            book = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("\tBook\t Authors \tPrice \tQuantity\n");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].GetName().Equals(book))
                {
                    Author[] a = books[i].GetAuthors();
                    string name = "\t";
                    for (int j = 0; j < a.Length; j++)
                    {
                        name += a[j].GetName() + " ";
                    }

                    Console.WriteLine("\t"+books[i].GetName() + name + "  \t$" + books[i].GetPrice()  + "\t " +books[i].GetQty());
                }
            }
            Console.ReadKey();
        }

        static void CheckOut(User user)
        {
            Book[] cart = user.GetShoppingCart();
            double bill = 0;

            Console.WriteLine("\n\t\tList of books in cart\n");

            for (int i = 0; i < cart.Length; i++)
            {
                Book b1 = new Book();
                b1 = cart[i];
                Console.Write("\t" + (i + 1) + ". " + b1.GetName());
                Console.Write("\t$" + b1.GetPrice());
                Console.WriteLine("\t" + b1.GetQty() + " books");
            }

            for (int i = 0; i < cart.Length; i++)
            {
                Book b2 = new Book();
                b2 = cart[i];
                bill += b2.GetQty() * b2.GetPrice();
            }

            Console.WriteLine("Your bill is $" + bill);
            Console.ReadKey();
            for (int i = 0; i < cart.Length; i++)
            {
                Book b = new Book();
                b = cart[i];
                user.RemoveFromCart(cart[i]);
            }
            Console.Clear();
        }

        //static void SearchBookAuthor(User user)
        //{
        //    Console.Clear();
        //    Author[] authors = user.GetAuthors();

        //    string author;

        //    Console.WriteLine("Please Enter an Author Name");
        //    Console.WriteLine("");

        //    for (int i = 0; i < authors.Length; i++)
        //    {
        //        //if (authors[i].GetName().Equals(author))
        //        {
        //            Book[] b = authors[i].GetBooks();
        //            string name = "\t";
        //            for (int j = 0; j < b.Length; j++)
        //            {
        //                name += b[j].GetName() + " ";
        //            }

        //            Console.WriteLine(authors[i].GetName());
        //        }
        //    }

        //    Console.WriteLine("a");
        //    Console.ReadKey();
        //}
    }
}

