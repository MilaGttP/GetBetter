using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetBetter.Model
{
    [Table("resources")]
    public class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("type")]
        [StringLength(32)]
        public string Type { get; set; }

        [Required]
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }

        [Column("link")]
        [StringLength(128)]
        public string Link { get; set; }

        [Column("views_quantity")]
        public int ViewsQuantity { get; set; }

        [Column("likes_quantity")]
        public int LikesQuantity { get; set; }

        [Column("image")]
        [StringLength(64)]
        public string Image { get; set; }
    }
}
