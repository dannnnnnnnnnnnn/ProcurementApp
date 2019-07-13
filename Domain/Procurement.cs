using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Procurement : DomainEntity
    {
        [MaxLength(256)]
        [MinLength(1)]
        [Required]
        public string Name { get; set; }
        public ICollection<ProcurementObject> ProcurementObjects { get; set; }
    }
}