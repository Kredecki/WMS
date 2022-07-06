using System.ComponentModel.DataAnnotations;

namespace WMS.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Range(8, 50, ErrorMessage = "Password must be between 8 and 50 characters")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int GroupId { get; set; }
        public int Rankid { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Modification { get; set; }
    }
}
