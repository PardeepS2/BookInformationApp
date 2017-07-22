using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    public class Data
    {
        // variables declare for book information

        static int choice;
        static User user;
        //static string bookname;
        //static double price;
       // static int quantity;
       // static Date date;

        // variables declare for author infomation

      //  static string authorname;
       // static string email;
       // static Date DateOfBirth;
        
        

        public static void FillData()
        {
            int choice;

            Console.WriteLine("\tWelCome To The BookInfomation Application\n");
            Console.WriteLine("1. List of Available Books");
            Console.WriteLine("2. List of Authors");
            Console.WriteLine("3. List of Favourite Authors");
            Console.WriteLine("4. Shopping Cart");           
            Console.WriteLine("5. Exit program");

            

            choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:


                    AvailableBooks();
                 //   Console.WriteLine("case 1");
                    Console.ReadKey();
                   Console.Clear();
                    
                    break;

                case 2:
                    Console.WriteLine("case 2");
                    break;

                case 3:
                    Console.WriteLine("case 3");
                    break;

                case 4:
                    Console.WriteLine("case 4");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 6:
                    Console.WriteLine("case 6");
                    break;
            }


        }

        public static void AvailableBooks()
        {
            Book book = new Book();
            string[] listofbooks = {"1. Let Us C  By  Sam", "2. Complete Java  By  Jeewan"};

            for (int i = 0; i < listofbooks.Length; i++)
            {
                Console.WriteLine(listofbooks[i]);               
            }
            choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listofbooks.Length; i++)
            {
                if (i == choice)
                {
                    Console.WriteLine("its working");
                }
                else
                {
                    Console.WriteLine("Its not");
                }
               
            }


           // Console.Clear();

           

            //Console.WriteLine()
        }
    }
}
