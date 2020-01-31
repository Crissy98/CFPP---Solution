using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CFPP.Database.Entities
{
    [Table("Case")]
    public class Case
    {
        public Guid CaseId { get; set; }

        //unique code refference
        public string CaseRef { get; set; }

        [Required(ErrorMessage = "Invoice Due Date is required")]
        public DateTime InvoiceDueDate { get; set; }

        public bool isDue { get; set; }

        public string OverdueDays { get; set; }

        [ForeignKey(nameof(Customer))]
        public Guid CustomerCode { get; set; }
        public Customer Customers { get; set; }
    }
}
