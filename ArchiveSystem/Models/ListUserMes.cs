using System.ComponentModel.DataAnnotations;

namespace ArchiveSystem.Models
{
    public partial class ListUserMes
    {
        [Key]
        public int UserId { get; set; } // Represents the ID of the user associated with the message
        public int MessageId { get; set; } // Represents the ID of the message

        public virtual Message Message { get; set; } // Represents the navigation property for the associated message
        public virtual UserAcc User { get; set; } // Represents the navigation property for the associated user
    }

    public class ListOperate
    {
        public int UserId { get; set; } // Represents the ID of the user
        public int MessageId { get; set; } // Represents the ID of the message
    }
}
