using System.ComponentModel.DataAnnotations;

namespace DApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Must specify a password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}