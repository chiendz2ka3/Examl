using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    [Table("SubjectExam")]
    public class SubjectExam
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string SubJectName { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        [StringLength(50)]
        public string classroom { get; set; }
        [Required,StringLength(50)]
        public string Faculty { get; set; }
    }
}
