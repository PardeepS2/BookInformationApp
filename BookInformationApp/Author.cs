using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class Author
    {
        private string name;
        private Book[] books;
        private string email;
        private Date DOB;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public Author(string name, string email, char gender, Book[] books)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.books = books;
        }
        public string GetName()
        {
            return this.name;
        }

        public Book[] GetBooks()
        {
            return this.books;
        }

        public Date GetDOB()
        {
            return this.DOB;
        }

        public void SetDOB(Date date)
        {
            
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
             this.email = email;
        }

        public char GetGender()
        {
            return this.gender;
        }

        public void SetGender(char gender)
        {
            this.gender = gender;
        }


    }
}
