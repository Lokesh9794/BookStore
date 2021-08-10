using System;
using BookStore.Models;
using System.Collections.Generic;
using System.Linq;
using  BookStore.Data;
using System.Threading.Tasks;
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
                    UpdatedOn=DateTime.UtcNow
            };

           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();
            return newBook.Id
;        }
        public List<BookModel> GetAllBook()
        {
            return null;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            var book=await _context.Books.FindAsync(id);
            if (book != null)
            {
                var bookDetails= new BookModel()
                {
                    Author=book.Author,
                    Category=book.Category,
                    Title =book.Title,
                    Description=book.Description,
                    Pages=book.Pages,
                    Id=book.Id,
                    LanguageId=book.LanguageId,
                };
                return bookDetails;
            }
            //return DataSource().Where(x=> x.Id==id).FirstOrDefault();
            return null;
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return null;
        }
    }
}
