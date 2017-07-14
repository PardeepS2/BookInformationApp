using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class Book
    {
        private string name;
       // private  Author[];
        private double price;
        private DateTime publication;
        private int qty = 0;

        public Book(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public Book(string name, double price, int qty)
        {
            this.name = name;
            this.price = price;
            this.qty = qty;
        }


    }
}
