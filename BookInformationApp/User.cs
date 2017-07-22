using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class User
    {
        private List<Author> favoriteAuthors;
        private List<Book> ShoppingCart;

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

        public void RemoveAuthor(Author author)
        {
            favoriteAuthors.Remove(author);
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
