using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSBasics
{
    internal class Book
    {
        public string Title { get; }
        public int Pages { get; }
        public int CurrentPage { get; private set; } 

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            CurrentPage = 1; // default starting page is 1
        }

        public void TurnPage(int change)
        { 
            int newPage = CurrentPage + change;
            if (newPage >= 1 && newPage <= Pages)
            {
                CurrentPage = newPage;
                Console.WriteLine($"You are now on page {CurrentPage}");
            }
            else
            {
                Console.WriteLine("That page doesn't exist in this book.");
            }
        }
    }
}
