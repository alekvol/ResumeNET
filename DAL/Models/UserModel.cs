using System.ComponentModel.DataAnnotations;
namespace ResumeNET.DAL.Models
{
    public class UserModel
    {
        [Key]
        public int? UsertId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Salt { get; set; } = null!;
        public int Status { get; set; } = 0;

    }
}
