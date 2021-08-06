using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Models;
using BookStore.Repo;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BookStore.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _bookrepo =null;

        public BookController(BookRepository bookRepository)
        {
            _bookrepo= bookRepository;
        }
        public ViewResult GetAllBooK()
        {
            var  data=_bookrepo.GetAllBook();
            return View(data);
        }

        public async Task<ViewResult >GetBooK(int id)
        {
            var data= await _bookrepo.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return _bookrepo.SearchBook(bookName,authorName);
        }

        public ViewResult AddNewBook(bool isSuccess=false, int bookId=0)
        {
           var model =new BookModel()
            {
               // Language="3"
            };
 
            ViewBag.IsSuccess=isSuccess;
            ViewBag.BookId=bookId;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult>  AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
             int id= await _bookrepo.AddNewBook(bookModel);

           if(id>0){
               return RedirectToAction(nameof(AddNewBook),new{ isSuccess=true, bookId=id});
           }   
            }

            
            return View();
        }

        private List<LanguageModel> GetLanguages()
        {
            return new List<LanguageModel>()
            {
            new LanguageModel() { Id=1,Text = "English"},
            new LanguageModel() { Id=2,Text = "Hindi"},
            new LanguageModel() { Id=3,Text = "Urdu"},
            };
        }
    }
}