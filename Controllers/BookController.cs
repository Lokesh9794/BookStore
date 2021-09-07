using System.Net.Mime;
using System;
using System.IO;
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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;


namespace BookStore.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _bookrepo =null;
        private readonly LanguageRepository _langrepo =null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BookController(BookRepository bookRepository, LanguageRepository langrepository, IWebHostEnvironment webHostEnvironment)
        {
            _bookrepo= bookRepository;
            _langrepo= langrepository;
            _webHostEnvironment= webHostEnvironment;
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
                if(bookModel.CoverPhoto !=null)
                {
                   string folder="books/CoverPhoto/";
                  bookModel.CoverImageUrl= await UploadImage(folder, bookModel.CoverPhoto);
                }

                if(bookModel.BookPdf !=null)
                {
                   string folder="books/BookPdf/";
                  bookModel.BookpdfUrl= await UploadImage(folder, bookModel.BookPdf);
                }

                if(bookModel.GallaryFiles !=null)
                {
                   string folder="books/gallary/";
                    bookModel.Gallery=new List<GalleryModel>();
                    foreach(var file in bookModel.GallaryFiles)
                    {
                        var gallery=new GalleryModel()
                        {
                            Name = file.FileName,
                            URL= await UploadImage(folder, file)
                        };
                        bookModel.Gallery.Add(gallery);
                        
                    }
                }

             int id= await _bookrepo.AddNewBook(bookModel);

           if(id>0){
               return RedirectToAction(nameof(AddNewBook),new{ isSuccess=true, bookId=id});
           }   
            
        }
           ViewBag.lanaguage =new SelectList(await _langrepo.GetLanguages(),"Id","Name");
            
            return View();
        
    }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }


    }
}