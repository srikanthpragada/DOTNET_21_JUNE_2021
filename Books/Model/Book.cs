using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Model
{
    public class Book
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Author { get; set; }

        public int NoPages { get; set; }

        public int Rating { get; set; }

        [MaxLength(500)]
        public string Remarks { get; set; }

    }
}
