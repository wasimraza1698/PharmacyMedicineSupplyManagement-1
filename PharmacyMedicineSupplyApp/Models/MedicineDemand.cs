using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply.Models
{
    public class MedicineDemand
    {
        [Required]
        [DisplayName("Medicine")]
        public string MedicineName { get; set; }
        [Required]
        public int Count { get; set; }
    }
}
