using GetBetter.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetBetter.Model
{
    [Table("hws")]
    public class Homework
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("link_task")]
        [StringLength(128)]
        public string LinkTask { get; set; }

        [Column("link_completed")]
        [StringLength(128)]
        public string LinkCompleted { get; set; }

        [Column("feedback_teacher")]
        [StringLength(128)]
        public string FeedbackTeacher { get; set; }

        [Column("feedback_stud")]
        [StringLength(128)]
        public string FeedbackStud { get; set; }

        [Required]
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }

        [Column("mark")]
        public int? Mark { get; set; }

        [Column("issued")]
        public DateTime? Issued { get; set; }

        [Column("deadline")]
        public DateTime? Deadline { get; set; }

        [Column("is_completed")]
        public bool IsCompleted { get; set; }

        [Column("image")]
        [StringLength(64)]
        public string Image { get; set; }

        [Column("teacher_stud_id")]
        [ForeignKey("TeacherStudent")]
        public int TeacherStudId { get; set; }

        public virtual TeacherStudent TeacherStudent { get; set; }
    }
}
