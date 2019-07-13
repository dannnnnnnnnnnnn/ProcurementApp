using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.App.DTO
{
    public class ProcurementObject
    {
        public int Id { get; set; }
        [MaxLength(128)]
        [MinLength(1)]
        [Required]
        public string Name { get; set; }
        public int ProcurementId { get; set; }
        public Procurement Procurement { get; set; }
        public ICollection<ProcurementObjectRow> ProcurementObjectRows { get; set; }
    }
}