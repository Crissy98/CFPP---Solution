using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFPP.Database.Entities
{
    [Table("Customer")]
    public class Customer
    {

        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer Name is required")]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string CustomerName { get; set; }


        //cui client - default 7 cifre 
        [Required(ErrorMessage = "VAT Code is required")]
        [MaxLength(10, ErrorMessage = "Length must be less then 50 characters")]
        public string VATCode { get; set; }

        public CustomerDetails customerDetails { get; set; }

        public ICollection<Case> Cases { get; set; }

    }
}
