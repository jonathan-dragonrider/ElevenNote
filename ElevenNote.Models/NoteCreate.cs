using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Enter at least 1 character.")]
        [MaxLength(100, ErrorMessage = "Title limit is 100 characters.")]
        public string Title { get; set; }

        [MaxLength(8000, ErrorMessage = "Max length is 8000 characters.")]
        public string Content { get; set; }
    }
}
