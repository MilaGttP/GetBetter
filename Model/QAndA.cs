using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetBetter.Model
{
    [Table("qas")]
    public class QAndA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("question")]
        [StringLength(256)]
        public string Question { get; set; }

        [Required]
        [Column("answer")]
        [StringLength(256)]
        public string Answer { get; set; }
    }
}
