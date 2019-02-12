using System.ComponentModel.DataAnnotations;

namespace survey_validation.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name:")]
        public string uname {get; set;}

        [Required]
        [Display(Name = "Dojo Location:")]
        public string location {get; set;}

        [Required]
        [Display(Name = "Favorite Language:")]
        public string language {get; set;}
        
        [MinLength(20)]
        [Display(Name = "Comment(Optional):")]
        public string comment {get; set;}

        public User()
        {
        
        }
    }
}