using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class User
    {
        List<Author> favoriteAuthors = new List<Author>();
        List<Book> favoriteBooks = new List<Book>();
        List<Book> ShoppingCart = new List<Book>();

        public User()
        {

        }

        public void AddAuthor(Author author)
        {
            favoriteAuthors.Add(author);
        }

        public Author[] GetAuthors()
        {
            return this.favoriteAuthors.ToArray();
        }

        public Book[] GetShoppingCart()
        {
            return this.ShoppingCart.ToArray();
        } 

        public void AddToCart(Book book)
        {
            ShoppingCart.Add(book);
        }

        public void RemoveFromCart(Book book)
        {
            ShoppingCart.Remove(book);
        }

        public void AddBook(Book book)
        {
            favoriteBooks.Add(book);
        }

        public void RemoveBook(Book book)
        {
            favoriteBooks.Remove(book);
        }

        public void RemoveAuthor(Author author)
        {
            favoriteAuthors.Remove(author);
        }

        public Book[] GetBook()
        {
            return this.favoriteBooks.ToArray();
        }


        public string toString()
        {
            return string.Empty;
        }

        public string GetShoppingCart(List<Book> ShoopingCart)
        {
            return this.ShoppingCart.ToString();
        }      
    }
}
