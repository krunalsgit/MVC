using System.ComponentModel.DataAnnotations;
namespace MyModals
{
    public class StudentModal
    {
        public int id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " Please Enter First Name.")]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " Please Enter First Name.")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = " Please Enter Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Please Enter Password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = " Please Enter Address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = " Please Enter Gender.")]
        public string Gender { get; set; }
    }
}
