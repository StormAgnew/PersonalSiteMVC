using System.ComponentModel.DataAnnotations; //Grants access to annotations for validation

namespace PersonalSiteMVC
{
    public class ContactViewModel
    {
       

        [Required(ErrorMessage = "A name is required to continue!")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "A valid email is required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "You need to write a subject to send off an email.")]
        public string Subject { get; set; }



        [Required(ErrorMessage = "A message is required.")]
        [DataType(DataType.MultilineText)] 
        public string Message { get; set; }

    }
}
