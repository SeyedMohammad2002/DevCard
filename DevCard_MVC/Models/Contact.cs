using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(2, ErrorMessage = "حداقل طول نام ۲ کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام ۱۰۰ کارکتر است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }

        public string Message { get; set; }
        public string Service { get; set; }
    }
}