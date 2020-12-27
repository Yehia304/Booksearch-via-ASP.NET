using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booksearch.Models
{
    public class Book
    {
        public int Bookid { get; set; }
        public string Bookname  { get; set; }
        public bool Availability { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string BookType { get; set; }


    }
}