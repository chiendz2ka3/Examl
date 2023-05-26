using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    [Table("Faculty")]
    public class Faculty
    {
        [Key]
        public Guid id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
    }
}
