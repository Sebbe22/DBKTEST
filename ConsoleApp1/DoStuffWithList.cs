using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DoStuffWithList
    {
        public List<Book> bookList1 = new List<Book>()
        {
            new Book("4621", 20, "0", "0", "0"),
            new Book("4621", 23, "13", "22", "333"),
            new Book("1345", 2, "0", "0", "0"),
            new Book("9766", 0, "0", "0", "0"),
            new Book("5845", 7, "999", "420", "42"),
            new Book("5329", 100, "100", "473", "425"),
            new Book("0148", 200, "200", "240", "300"),
            new Book("1894", 0, "422", "62", "526"),
        };
        public List<Book> bookList2 = new List<Book>()
        {
            new Book("4621", 0, "200", "240", "300"),
            new Book("6353", 2, "0", "0", "0"),
            new Book("8476", 0, "0", "0", "0"),
            new Book("4145", 0, "999", "420", "42"),
            new Book("5329", 100, "0", "0", "0"),
            new Book("0148", 0, "2000", "2400", "3000"),
            new Book("1894", 0, "422", "62", "526"),
            new Book("9999", 0, "999", "999", "999"),
            new Book("8888", 0, "888", "888", "888"),
            new Book("7777", 3, "111", "111", "111"),
            new Book("6666", 0, "222", "222", "222"),
        };

        public List<Book> FilterList(List<Book> bookList, Dictionary<string, Book> dictionary = null)
        {
            if (dictionary == null)
            {
                dictionary = new Dictionary<string, Book>();
            }

            foreach (Book book in bookList)
            {
                string id = book.ISBN;

                Book? storedBook;
                dictionary.TryGetValue(id, out storedBook);

                if(storedBook is null)
                {
                    dictionary.Add(id, book);
                }
                else
                {
                    storedBook.MergeBook(book);
                }
                   
            }
            return dictionary.Values.ToList();
        }

        public Dictionary<string, Book> ToDictionary(List<Book> listOfBooks)
        {
            Dictionary<string, Book> dictionary = new Dictionary<string, Book>();
            foreach(Book book in listOfBooks)
            {
                dictionary.Add(book.ISBN, book);
            }
            return dictionary;
        }

        public List<Book> MergeLists(List<Book> primaryList, List<Book> secondaryList)
        {
            Dictionary<string, Book> dictionary = ToDictionary(secondaryList);

            return FilterList(primaryList, dictionary);
        }
    }
}
