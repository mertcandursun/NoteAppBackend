using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Entities
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Title { get; set; }
        [StringLength(5000, ErrorMessage = "Max 5000 characters")]
        public string Detail { get; set; }
    }
}
