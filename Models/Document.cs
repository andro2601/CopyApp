using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CopyApp.Models
{
    [Table("Document")]
    public class Document
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Document title attribute missing")]
        public string? Title { get; set; }
        [StringLength(127)]
        [Required(ErrorMessage = "Document author attribute missing")]
        public string? Author { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}