using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalTask.Data.Models
{
    [Table("FinanceRate", Schema = "dbo")]
    public class FinanceRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FinanceId { get; set; }
        [ForeignKey("FinanceId")]
        public Finance Finance { get; set; }
        public int FinanceRateTypeId { get; set; }
        [ForeignKey("FinanceRateTypeId")]
        public FinanceRateType FinanceRateType { get; set; }
        public double Rate { get; set; }
    }
}
