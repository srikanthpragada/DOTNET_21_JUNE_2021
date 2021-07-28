using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webdemo.Model
{

    [Table("products")]
    public class Product
    {
        [Column("prodid")]
        [Key]
        public int Id { get; set; }

        [Column("prodname")]
        public string Name { get; set; }

        [Column("qoh")]
        public int Qoh { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("remarks")]
        public string Remarks { get; set; }

        [Column("catcode")]
        public string Category { get; set; }

    }
}
