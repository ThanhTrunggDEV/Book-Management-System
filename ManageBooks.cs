using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public static class ManageBooks
    {
        public static List<Book> ListBooks = new List<Book>();
        private static int FindIndex(string input)
        {
            
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ';')
                    return i;
            }
            return 0;
        }
        static ManageBooks()
        { 
                List<string> Input = File.ReadAllLines("D:\\Coding Space\\C#\\BookManagementSystem\\Data.txt").ToList();
            for (int i = 0; i < Input.Count; i++)
            {
                int index = FindIndex(Input[i]);
                string Title = Input[i].Substring(0, index);
                Input[i] = Input[i].Substring(index + 1);

                index = FindIndex(Input[i]);
                string AuthorName = Input[i].Substring(0, index);
                Input[i] = Input[i].Substring(index + 1);

                index = FindIndex(Input[i]);
                bool ReadStatus = bool.Parse(Input[i].Substring(0, index));
                Input[i] = Input[i].Substring(index + 1);

                index = FindIndex(Input[i]);
                double BuyingPrice = double.Parse(Input[i].Substring(0, index));
                Input[i] = Input[i].Substring(index + 1);

                
                double OriginalPrice = double.Parse(Input[i]);
                ListBooks.Add(new Book(Title, AuthorName, BuyingPrice, OriginalPrice, ReadStatus));
            }
        }
        public static void SaveBooksToFile()
        {
            string BookData = string.Empty;
            foreach (var item in ListBooks)
            {
                   BookData += $"{item.Title};{item.AuthorName};{item.ReadStatus};{item.BuyingPrice};{item.OriginalPrice}\n";
            }
            File.WriteAllText("D:\\Coding Space\\C#\\BookManagementSystem\\Data.txt", BookData);
        }
        public static void AddBook(Book book)
        {
            ListBooks.Add(book);
        }
        public static void RemoveBook(Book book)
        {
            ListBooks.Remove(book);
        }
        public static void GetTotalBuyingPrice()
        {
            double totalPrice = 0;
            foreach (var item in ManageBooks.ListBooks)
            {
                totalPrice += item.BuyingPrice;
            }
            MessageBox.Show($"Your Total Amount Of Money With Discount Is {totalPrice} VNĐ");
        }
        public static void GetTotalOriginalPrice()
        {
            double totalPrice = 0;
            foreach (var item in ListBooks)
            {
                totalPrice += item.OriginalPrice;
            }
            MessageBox.Show($"Your Total Amount Of Money Without Discount Is {totalPrice} VNĐ");
        }
        public static void EditBook(Book oldBook, Book newBook)
        {
            int index = ListBooks.IndexOf(oldBook);
            ListBooks[index] = newBook;
        }
    }
}
