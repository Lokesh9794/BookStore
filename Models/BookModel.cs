using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id {get;set;}
        [StringLength(100,MinimumLength=5)]
        [Required(ErrorMessage = "*Please enter the title of the book")]
        public string Title {get;set;}
        [Required(ErrorMessage="*Please enter the Author name")]
        public string Author {get;set;} 
         [StringLength(500)]
        public string Description{get;set;}
        public string Category{get;set;}
        public string Language{get;set;}
        [Required(ErrorMessage="*Please enter the total number of pages")]
        public int? Pages {get;set;}

    }
}