using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArchiveSystem.Models
{
    public partial class _Attachment
    {
        [Key] // Specifies that the property below is the primary key
        public int _AttachmentId { get; set; }

        [ForeignKey(nameof(Message))] // Specifies the foreign key relationship with the Messages entity
        public int? MessageId { get; set; }

        [Required(ErrorMessage = "Attachment description is required")]
        public string AttDesc { get; set; } // Represents the description of the attachment
        [Required(ErrorMessage = "Attachment name is required")]
        public string AttFile { get; set; } // Represents the file name or path of the attachment (photo)

        public virtual Message Message { get; set; } // Navigation property representing the associated Messages entity
    }
}
