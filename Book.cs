using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool ReadStatus { get; set; }
        public double BuyingPrice { get; set; }
        public Book(string Title, string AuthorName, double BuyingPrice, bool ReadStatus)
        {
            this.Title = Title;
            this.ReadStatus = ReadStatus;
            this.AuthorName = AuthorName;
            this.BuyingPrice = BuyingPrice;
        }
    }
}
