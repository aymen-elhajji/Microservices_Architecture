using System.ComponentModel.DataAnnotations;

namespace BusinessObjects
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public Product? Product { get; set; }
    }
}
