using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFPP.Database.Entities
{
    [Table("Case")]
    public class Case
    {
        [Key]
        [Column("CustomerCode")]
        public int CaseId { get; set; }
        public string CaseTitle { get; set; }

        //public decimal TotalBallance { get; set; }
        //public decimal OverdueBallance { get; set; }

        public int? DPD { get; set; }
        public Customer customer { get; set; }
        public int? CustomerId { get; set; }

    }
}
