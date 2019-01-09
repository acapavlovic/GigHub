using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModel
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}