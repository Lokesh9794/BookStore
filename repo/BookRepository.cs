using System;
using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repo
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.Id==id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="Java",Author="Lokesh",Description="This is a Java Book",Category="Action",Language="English",Pages=1067},
                new BookModel(){Id=2,Title="Database",Author="Lokesh",Description="This is a Database Book",Category="Coding",Language="English",Pages=655},
                new BookModel(){Id=3,Title="Php",Author="Ls",Description="This is a PHP Book",Category="Programming",Language="English,Latin",Pages=1000},
                new BookModel(){Id=4,Title="Html",Author="Lokesh",Description="This is a Html Book",Category="Action",Language="Markup",Pages=1007},
                new BookModel(){Id=5,Title="DA",Author="Lokesh Sharma",Description="This is a Data structure Book",Category="Action",Language="English",Pages=1067},
            };
        }

    }
}
