﻿using System;
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

        public Book(string name, Author[] authors, double price, Date publication, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.publication = publication;
            this.qty = qty;
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
            Date date;
            date = this.publication;
            return date;
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
            string bookinfo = "\nbookname:\t"  + this.GetName()  
                                +  "\nAuthorName:\t" + this.GetAuthorName() 
                               + "\nPrice:\t"   + this.GetPrice() 
                               + "\nPublication Date:\t"  + this.GetPublicationDate() 
                                  + "\nQuantity:\t" + this.GetQty();
            return bookinfo;
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
