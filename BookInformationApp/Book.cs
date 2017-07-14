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

        public string GetName()
        {
            return this.name;
        }
        
        //get Author

        public DateTime GetPublicationDate()
        {
            return this.publication;
        }

        /*public void SetPublicationDate(DateTime date)
        {
            this.
        }*/

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public int GetQty()
        {
           return  this.qty;
        }

        public void SetQty(int qty)
        {
            this.qty = qty;
        }

        public string toString()
        {
            return String.Format("");
        }

       /* public string GetAuthorNames()
        {

        }*/
    }
}
