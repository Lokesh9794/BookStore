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
                    Description=model.Description,
                    Pages=model.Pages,
                    UpdatedOn=DateTime.UtcNow
            };

           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();
            return newBook.Id
;        }
        public List<BookModel> GetAllBook()
        {
            return DataSource();
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
                    Language=book.Language,
                };
                return bookDetails;
            }
            //return DataSource().Where(x=> x.Id==id).FirstOrDefault();
            return null;
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
