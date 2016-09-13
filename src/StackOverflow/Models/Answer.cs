using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflow.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Question Question { get; set; }
    }
}