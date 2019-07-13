using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ProcurementObject : DomainEntity
    {
        [MaxLength(128)]
        [MinLength(1)]
        [Required]
        public string Name { get; set; }
        public int ProcurementId { get; set; }
        public Procurement Procurement { get; set; }
        public ICollection<ProcurementObjectRow> ProcurementObjectRows { get; set; }
    }
}