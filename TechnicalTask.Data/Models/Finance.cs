using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalTask.Data.Models
{
    [Table("Finance", Schema = "dbo")]
    public class Finance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int MakeId { get; set; }
        [ForeignKey("MakeId")]
        public Make Make { get; set; }
        public int VehicleTypeId { get; set; }
        [ForeignKey("VehicleTypeId")]
        public VehicleType VehicleType { get; set; }
        public int FinanceTypeId { get; set; }
        [ForeignKey("FinanceTypeId")]
        public FinanceType FinanceType { get; set; }
        public ICollection<FinanceRate> FinanceRates { get; set; }
    }
}
