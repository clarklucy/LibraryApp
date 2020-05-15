using System;
using System.ComponentModel.DataAnnotations;


namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAquired { get; set; }
        public bool InCirculation { get; set; }

        //CoverImage

    }
}