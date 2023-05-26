
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ArchiveSystem.Models
{
    public partial class UserAcc
    {
        public UserAcc()
        {
            Messages = new HashSet<Message>();
            ListUserMes = new HashSet<ListUserMes>();
        }

        [Key]
        public int UserAccID { get; set; } // Represents the ID of the user account
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; } // Represents the username

        // Unique constraint on AcadMail property
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        public string AcadMail { get; set; } // Represents the academic email address

        [Range(8, 20, ErrorMessage = "Password is required")]
        public string Pass { get; set; } // Represents the password
      
        public string JobTitle { get; set; } // Represents the job title

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone should be exactly 11 characters")]
        public string Phone { get; set; } // Represents the phone number

        [Required(ErrorMessage = "IsAdmin is required")]
        public bool IsAdmin { get; set; } // Represents whether the user is an admin or not
        [NotNull]
        [Required(ErrorMessage = "Active is required")]
        public bool Active { get; set; } // Represents whether the user account is active or not
        
        public string Department { get; set; } // Represents the department of the user

        [Range(typeof(Gender), "Male", "Female", ErrorMessage = "Invalid gender")]
        public Gender userGender { get; set; } // Represents the gender of the user

        public virtual ICollection<Message> Messages { get; set; } // Represents the collection of messages associated with the user
        public virtual ICollection<ListUserMes> ListUserMes { get; set; } // Represents the collection of user-message associations
    }

    public class Login
    {
        public string Email { get; set; } // Represents the email for login
        public string Password { get; set; } // Represents the password for login
    }

    public class User
    {
        public int UserAccID { get; set; } // Represents the ID of the user account
        public string UserName { get; set; } // Represents the username
        public string AcadMail { get; set; } // Represents the academic email address
        public string Pass { get; set; } // Represents the password
        public string JobTitle { get; set; } // Represents the job title
        public string Phone { get; set; } // Represents the phone number
        public bool IsAdmin { get; set; } // Represents whether the user is an admin or not
        public Gender userGender { get; set; } // Represents the gender of the user
    }

    public class UserViewModel
    {
        public string UserName { get; set; } // Represents the username
        public string Phone { get; set; } // Represents the phone number
    }

    public enum Gender
    {
        Male,
        Female
    }
}
