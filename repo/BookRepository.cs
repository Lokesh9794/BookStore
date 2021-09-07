using System;
using BookStore.Models;
using System.Collections.Generic;
using System.Linq;
using  BookStore.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BookStore.Repo
{
    public class BookRepository
    {
        private readonly BookStoreContext _context=null;
        public BookRepository(BookStoreContext context)
        {
            _context= context;
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook=new  Books()
            {
                    Author=model.Author,
                    CreatedOn=DateTime.UtcNow,
                    Title =model.Title,
                    LanguageId=model.LanguageId, 
                    Description=model.Description,
                    Pages=model.Pages.HasValue ? model.Pages.Value : 0,
                    UpdatedOn=DateTime.UtcNow,
                    CoverImageUrl=model.CoverImageUrl,
            };
            newBook.bookGallery=new List<BookGallery>();
             foreach (var file in model.Gallery)
                    {
                        newBook.bookGallery.Add(new BookGallery()
                        {
                            Name=file.Name,
                            URL=file.URL 
                        });
                    }

           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();
            return newBook.Id
;        }
            public async Task<List<BookModel>> GetAllBook()
        {
            return await _context.Books
                  .Select(book => new BookModel()
                  {
                      Author = book.Author,
                      Category = book.Category,
                      Description = book.Description,
                      Id = book.Id,
                      LanguageId = book.LanguageId,
                      Language = book.Language.Name,
                      Title = book.Title,
                      Pages = book.Pages,
                      CoverImageUrl=book.CoverImageUrl,
                      //CoverImageUrl = book.CoverImageUrl
                  }).ToListAsync();
        }

        public async Task<BookModel> GetBookById(int id)
        {
           return await _context.Books.Where(a => a.Id == id).Select(book => new BookModel()
           {
               Author=book.Author,
               Category=book.Category,
               Description=book.Description,
               Id=book.Id,
                LanguageId=book.LanguageId,
               Language=book.Language.Name,
               Title=book.Title,
               Pages=book.Pages,
               CoverImageUrl=book.CoverImageUrl,
               Gallery=book.bookGallery.Select(g=> new GalleryModel()
               {
                   Id=g.Id,
                   Name=g.Name,
                   URL=g.URL,
               }).ToList()
           }).FirstOrDefaultAsync();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return null;
        }
    }
}
