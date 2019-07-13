using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.App.DTO
{
    public class ProcurementObjectRow
    {
        public int Id { get; set; }
        [Range(1000, 3000)]
        public int Year { get; set; }
        [Range(0, Int32.MaxValue)]
        public int Amount { get; set; }
        [Range(0, Double.MaxValue)]
        public double Price { get; set; }
        public double Sum { get; set; }
        public int ProcurementObjectId { get; set; }
        public ProcurementObject ProcurementObject { get; set; }
    }
}