using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
        
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone No is required")]
        public string PhoneNo { get; set; }

    }
}
