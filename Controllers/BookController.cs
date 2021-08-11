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
using BookStore.repo;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BookStore.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _bookrepo =null;
        private readonly LanguageRepository _langrepo =null;

        public BookController(BookRepository bookRepository, LanguageRepository langrepository)
        {
            _bookrepo= bookRepository;
            _langrepo= langrepository;
        }
        public async Task<ViewResult> GetAllBooK()
        {
            var  data=await _bookrepo.GetAllBook();
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

        public async Task<ViewResult >AddNewBook(bool isSuccess=false, int bookId=0)
        {
           var model =new BookModel()
            {
               // Language="3"
            };

            ViewBag.lanaguage =new SelectList(await _langrepo.GetLanguages(),"Id","Name");

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
           ViewBag.lanaguage =new SelectList(await _langrepo.GetLanguages(),"Id","Name");
            
            return View();
        }
    }
}