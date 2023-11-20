using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sof_feleves.Models
{
    public class Appointment
    {
        public Appointment()
        {
            ID = Guid.NewGuid().ToString();
        }

        [Key]
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public int MaxApplicants { get; set; }

        public string ServiceID { get; set; }
        public virtual Service Service { get; set; }

        [NotMapped]
        public virtual ICollection<SiteUser>? Applicants { get; set; }
    }
}
