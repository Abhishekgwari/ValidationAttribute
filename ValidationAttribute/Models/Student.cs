using System.ComponentModel.DataAnnotations;

namespace ValidationAttribute.Models
{
    public class Student

    {
        [Required(ErrorMessage ="Name is  must")]
        [StringLength(15,MinimumLength =3, ErrorMessage ="Name must be  within 3 to 15 character ")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email is  must")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is  must")]
        [Range(18,60,ErrorMessage ="Age must be within 18 to 60")]
        public int? Age { get; set; }                           // ? its null
    }
}
