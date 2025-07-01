using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Hospital.Domain_Classes
{
    internal class Prescriptions
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public int MedicationId { get; set; }
    }
}
