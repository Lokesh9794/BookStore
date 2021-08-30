using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using BookStore.Enum;
using BookStore.Helper;

using Microsoft.AspNetCore.Http;

namespace BookStore.Models
{
    public class BookModel
    {
      //  [DataType(DataType.Date)] //used to added  automatically datatype in view
       // [Display(Name="Choose Date")]  // this property is used to display the name of lable 
       // public int MyCustomField {get;set;} 
        public int Id {get;set;}
        //[StringLength(100,MinimumLength=5)]
       [Required(ErrorMessage = "*Please enter the title of the book")]
        //[MyCustomValidation ("Book")]
        public string Title {get;set;}
        [Required(ErrorMessage="*Please enter the Author name")]
        public string Author {get;set;} 
         [StringLength(500)]
        public string Description{get;set;}
        public string Category{get;set;}
        [Required(ErrorMessage="*Please Choose Language of Your book")]
        public int LanguageId{get;set;}
        public string Language{get;set;}
        [Required(ErrorMessage="*Please enter the total number of pages")]
        public int? Pages {get;set;}
        [Display(Name="Choose A cover photo")]
        [Required]
        public IFormFile CoverPhoto{get;set;}

    }
}