using System.ComponentModel.DataAnnotations;

namespace sof_feleves.Models
{
    public class Post
    {
        public Post()
        {
            ID = Guid.NewGuid().ToString();
        }

        [Key]
        public string ID { get; set; }

        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public string Text { get; set; }

        //public string? ImageContentType { get; set; }
        //public byte[]? ImageData { get; set; }

        public string ServiceID { get; set; }
        public virtual Service Service { get; set; }
    }
}
