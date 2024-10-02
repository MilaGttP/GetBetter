using GetBetter.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetBetter.Model
{
    [Table("lessons")]
    public class Lesson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("link")]
        [StringLength(128)]
        public string Link { get; set; }

        [Column("date_time")]
        public DateTime DateTime { get; set; }

        [Column("teacher_stud_id")]
        [ForeignKey("TeacherStudent")]
        public int TeacherStudId { get; set; }

        public virtual TeacherStudent TeacherStudent { get; set; }
    }
}
