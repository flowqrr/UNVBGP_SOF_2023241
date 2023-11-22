using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace sof_feleves.Models
{
    public class SiteUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? SurName { get; set; }

        [NotMapped]
        public virtual ICollection<Service>? HostedServices { get; set; }

        [NotMapped]
        public virtual ICollection<Appointment>? Appointments { get; set; }

        public string? ProfilePicContentType { get; set; }
        public byte[]? ProfilePicData { get; set; }
    }
}
