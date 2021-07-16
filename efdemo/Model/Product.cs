using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo.Model
{
    [Table("products")]
    public class Product
    {
        [Column("prodid")]
        [Key]
        public int Id { get; set; }

        [Column("prodname")]
        public string Name { get; set; }

        [NotMapped]
        public int Rol { get; set; }

    }
}
