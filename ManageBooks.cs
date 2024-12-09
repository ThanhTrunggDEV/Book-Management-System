﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class ManageBooks
    {
        public List<Book> ListBooks { get; set; }
        private int FindIndex(string input)
        {
            
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ';')
                    return i;
            }
            return 0;
        }
        public ManageBooks()
        {
            ListBooks = new List<Book>();
            List<string> Input = File.ReadAllLines("D:\\Coding Space\\C#\\BookManagementSystem\\BookManagementSystem\\Data.txt").ToList();
            for (int i = 0; i < Input.Count; i++)
            {
                int index = FindIndex(Input[i]);
                string Title = Input[i].Substring(0, index);
                Input[i] = Input[i].Substring(index + 1);

                index = FindIndex(Input[i]);
                string AuthorName = Input[i].Substring(0, index);
                Input[i] = Input[i].Substring(index + 1);

                index = FindIndex(Input[i]);
                int ReadStatus = int.Parse(Input[i].Substring(0, index));
                Input[i] = Input[i].Substring(index + 1);

                double BuyingPrice = double.Parse(Input[i]); 

                ListBooks.Add(new Book(Title, AuthorName, BuyingPrice, ReadStatus));
            }
        }
        public void AddBook(Book book)
        {
            ListBooks.Add(book);
        }
        public void RemoveBook(Book book)
        {
            ListBooks.Remove(book);
        }
        
        public Book SearchBook(string Title)
        {
            if (ListBooks.FirstOrDefault(item => item.Title == Title) == null)
            {
                throw new Exception($"Not Found Book Named {Title}");
            }
            else
                return ListBooks.First(item => item.Title == Title);
        } 
    }
}
