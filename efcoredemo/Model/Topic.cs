using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    public class Topic
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        public int Hours { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }  // Navigation Property 
    }
}
