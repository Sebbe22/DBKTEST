using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public string ISBN { get; set; }
        public int AMOUNT { get; set; }
        public string WEIGTH { get; set; }
        public string WIDTH { get; set; }
        public string THICKNESS { get; set; }

        public Book() { }

        public Book(string isbn, int amount, string weigth, string width, string thickness)
        {
            ISBN = isbn;
            AMOUNT = amount;
            WEIGTH = weigth;
            WIDTH = width;
            THICKNESS = thickness;
        }

        public void MergeBook(Book book)
        {
            AMOUNT = book.AMOUNT + AMOUNT;

        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, AMOUNT: {AMOUNT}, WEIGHT: {WIDTH}, THICKNESS: {THICKNESS}";
        }
    }
}
