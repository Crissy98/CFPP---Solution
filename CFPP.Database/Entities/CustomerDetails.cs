using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFPP.Database.Entities
{
    [Table("CustomerDetails")]
    public class CustomerDetails
    {
        [Key]
        [Column("CustomerDetailsId")]
        public int CustomerDetailsId { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone No is required")]
        public string PhoneNo { get; set; }

        public DateTime? JoinDate { get; set; }

        // FK 
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer customer { get; set; }


    }
}
