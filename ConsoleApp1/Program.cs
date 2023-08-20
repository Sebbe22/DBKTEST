// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Diagnostics;

//Console.WriteLine("Hello, World!");


//DoStuffWithList liststuff = new DoStuffWithList();
Stopwatch sw = Stopwatch.StartNew();
sw.Start();

Dictionary<int, bool> dict = new Dictionary<int, bool>();
Random random = new Random();
for (int i = 0; i < 500000; i++)
{

    //int number = random.Next();
    //if (dict.ContainsKey(number))
    //{
    //    continue;
    //}
    //dict.Add(number, true);
    Console.WriteLine( "hello");

}
sw.Stop();
Console.WriteLine(sw.Elapsed);
//List<Book> filteredDictionary1 = liststuff.FilterList(liststuff.bookList1);
//List<Book> filteredDictionary2 = liststuff.FilterList(liststuff.bookList2);



//string name = "belle";