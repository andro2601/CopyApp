using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CopyApp.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public Document? Document { get; set; }
        public int Copies { get; set; }
        public bool OneSided { get; set; }
        public bool PrintBlackWhite { get; set; }
        [Precision(8,2)]
        public decimal Price { get; set; }
    }
}