using System.ComponentModel.DataAnnotations;

namespace ValidationAttribute.Models
{
    public class Student

    {
        [Required(ErrorMessage ="Name is  must")]
        //[StringLength(15,MinimumLength =3, ErrorMessage ="Name must be  within 3 to 15 character ")]
        // [MaxLength(15)]
        [MinLength(3 ,ErrorMessage ="Minimum length must be 3 character")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email is  must")]
        //[EmailAddress]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = " Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is  must")]
        [Range(18,60,ErrorMessage ="Age must be within 18 to 60")]
        public int? Age { get; set; }                           // ? its null

        //[Required(ErrorMessage = "Password is must")]
        //[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$",
        //    ErrorMessage = "Password must include at least one uppercase letter, one lowercase letter, one number, one symbol, and be at least 8 characters long.")]
        //public string Password { get; set; }


        //[Required(ErrorMessage = "Confirm Password is must")]
        //[Compare("Password",ErrorMessage ="Both password must be identical")]
        //public string ConfirmPassword { get; set; }


        //[Required(ErrorMessage = "Phone Number is must")]
        //[RegularExpression("^[6-9]\\d{9}$", ErrorMessage = "Please enter a valid 10-digit Indian mobile number.")]
        //public string MobileNo { get; set; }



        //[Required(ErrorMessage = "Url is must")]
        //[Url(ErrorMessage ="Invalid URL")]
        //public string WebsiteURL { get; set; }

    }
}
