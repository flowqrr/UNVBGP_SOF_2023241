using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sof_feleves.Models
{
    public class Service
    {
        public Service()
        {
            ID = Guid.NewGuid().ToString();
        }

        [Key]
        public string ID { get; set; }

        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }

        public string HostID { get; set; }
        public virtual SiteUser Host { get; set; }

        [NotMapped]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [NotMapped]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
