using System;
using System.Collections.Generic;
using  BookStore.Data;
using System.Threading.Tasks;
using BookStore.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace BookStore.repo
{
    public class LanguageRepository
    {
        private readonly BookStoreContext _context=null;

        public LanguageRepository(BookStoreContext context)
        {
            _context= context;
        }

        public async Task<List<LanguageModel>> GetLanguages() 
        {
           return await _context.Language.Select(x=> new LanguageModel()
            {
                 Id=x.Id,
                 Description=x.Description,
                 Name=x.Name
            }).ToListAsync();
        }
    }
}