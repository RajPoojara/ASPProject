using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASPProject.Models
{
    [Table("Users")]
    public class UserInfo
    {
        [Display(Name = "User ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string DisplayName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(6, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Gender { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MinLength(10, ErrorMessage = "{0} cannot be less than {1} digits.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [Range(6,20, ErrorMessage ="{0} must be between {1} to {2}.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string RoleType { get; set; }
    }
}
