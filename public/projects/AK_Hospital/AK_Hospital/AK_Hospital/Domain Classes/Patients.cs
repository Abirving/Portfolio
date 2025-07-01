using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Hospital.Domain_Classes
{
    internal class Patients
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public int Age { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }


    }
}
