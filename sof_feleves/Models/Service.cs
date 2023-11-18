using System.ComponentModel.DataAnnotations;

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
        public string Name { get; set; }
        public string HostID { get; set; }
    }
}
