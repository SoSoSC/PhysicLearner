using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhysicLeaner.Models
{
    public class EmailModel
    {
        [Required(ErrorMessage = "Please enter the destination email address.")]
        [Display(Name = "To Email:")]
        public string To { get; set; }
        [Display(Name = "Suject:")]
        [Required(ErrorMessage = "Please enter the subject.")]
        public string Subject { get; set; }
        [Display(Name = "Body:")]
        [Required(ErrorMessage = "Please enter the body.")]
        public string Body { get; set; }
        [Display(Name = "File Attachment:")]
        [Required]
        public HttpPostedFileBase Attachment { get; set; }
        [Display(Name = "From Google Email:")]
        //[RegularExpression("\@gmail([\.])com$", ErrorMessage ="It's not a google email.")]
        [Required(ErrorMessage = "Please enter your personal email address.")]
        public string Email { get; set; }
        [Display(Name = "Email Password:")]
        [Required(ErrorMessage = "Please enter your personal email password.")]
        public string Password { get; set; }
    }
}