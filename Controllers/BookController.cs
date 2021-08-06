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
                ViewBag.Language= new List<SelectListItem>()
                {
                    new SelectListItem(){Text="Hindi", Value="1", Selected=true},
                    new SelectListItem(){Text="Punjabi", Value="2",Disabled=true},
                    new SelectListItem(){Text="Tamil", Value="3"},
                    new SelectListItem(){Text="English", Value="4"},
                }; 
               // ViewBag.Language= new List<string>(){"Hindi" , "English","French"};
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

            ViewBag.Language= new SelectList(GetLanguages(),"Id","Text");
            // ViewBag.Language= new List<string>(){"Hindi" , "English","French"};
           // ModelState.AddModelError("","In this line we can add any custom error message"); //Add custom error massgse along with validation
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