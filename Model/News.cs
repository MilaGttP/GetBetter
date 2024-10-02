using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetBetter.Model
{
    [Table("news")]
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("header")]
        [StringLength(64)]
        public string Header { get; set; }

        [Required]
        [Column("description")]  
        [StringLength(512)]
        public string Description { get; set; }

        [Column("image")]
        [StringLength(64)]
        public string Image { get; set; }
    }
}
