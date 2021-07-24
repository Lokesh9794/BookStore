using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Models;
using BookStore.Repo;

namespace BookStore.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _bookrepo =null;

        public BookController()
        {
            _bookrepo= new BookRepository();
        }
        public ViewResult GetAllBooK()
        {
            var  data=_bookrepo.GetAllBook();
            return View(data);
        }

        public ViewResult GetBooK(int id)
        {
            var data= _bookrepo.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return _bookrepo.SearchBook(bookName,authorName);
        }
    }
}