using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Patient
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]

        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string Dob { get; set; }
        [Required]
        [StringLength(50)]
        public string BloodGroup { get; set; }

        public Patient()
        {
            this.HospitalPatients = new List<HospitalPatient>();
            this.DoctorPatients = new List<DoctorPatient>();
        }
        public virtual List<HospitalPatient> HospitalPatients { get; set; }
        public virtual List<DoctorPatient> DoctorPatients { get; set; }
    }
}
