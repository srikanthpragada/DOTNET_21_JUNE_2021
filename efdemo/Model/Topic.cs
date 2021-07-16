
using System.ComponentModel.DataAnnotations;

namespace efdemo.Model
{
    public class Topic
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }
        public int Hours { get; set; }

        // Navigation Property
        public virtual Course Course { get; set; }
    }
}
