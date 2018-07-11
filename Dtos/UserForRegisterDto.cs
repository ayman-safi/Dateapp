using System.ComponentModel.DataAnnotations;

namespace DatingApp.api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8 , MinimumLength=4 ,
        ErrorMessage = "you must spcify password betwwen 4 and 8 char")]
        public string Password { get; set; }
    }
}