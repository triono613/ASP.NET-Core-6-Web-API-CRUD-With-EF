using System.ComponentModel.DataAnnotations;

namespace trionoNetCoreAPI.Models
{
    public class Users
    {
        [Key]
        public Guid userId { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
    }
}
