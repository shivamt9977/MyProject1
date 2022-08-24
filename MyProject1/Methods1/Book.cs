using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Book
    {
        string bookname;
        int price;
        string authorname;

        public string BookName
        { set { bookname = value; }
            get { return bookname; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public string AuthorName
        {
            set { authorname = value; }
            get { return authorname; }
        }


        static void Main(string[] args)
        {
            Book b = new Book();
            b.BookName="Tomb of Sand";
            b.Price = 800;
            b.AuthorName = "Geetanjali shree";

            Console.WriteLine(b.BookName);
            Console.WriteLine(b.Price);
            Console.WriteLine(b.AuthorName);
        }
    }
}
