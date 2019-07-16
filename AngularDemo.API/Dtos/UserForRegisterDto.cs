using System.ComponentModel.DataAnnotations;

namespace AngularDemo.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must enter a valid password")]
        public string Password {get; set;}
    
    }
}