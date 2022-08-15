using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public class UserPassword
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users User { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] HashPassword { get; set; }
    }
}