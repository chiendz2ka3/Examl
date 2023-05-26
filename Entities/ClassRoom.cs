using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    [Table("ClassRoom")]
    public class ClassRoom
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
    }
}
