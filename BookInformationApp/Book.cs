using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class Book
    {
         string name;
        private  Author[] authors;
        private double price;
        private Date publication;
        private int qty = 0;

        public Book()
        {

        }

        public Book(string name,Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
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
        
        public Author[] GetAuthors()
        {
            return this.authors;
            
        }

        public Date GetPublicationDate()
        {
            return this.publication;
        }

        public void SetPublicationDate(Date date)
        {
            this.publication = date;
        }
        

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

        public string GetAuthorName()
        {
            string name = "";
            for (int i = 0; i < this.authors.Length; i++)
            {
                name = name + ", " + this.authors[i];
            }
            return name;
        }
    }
}
