using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetBetter.Model
{
    [Table("students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(16)]
        public string Name { get; set; }

        [Required]
        [Column("surname")]
        [StringLength(16)]
        public string Surname { get; set; }

        [Column("patronymic")]
        [StringLength(16)]
        public string Patronymic { get; set; }

        [Required]
        [Column("email")]
        [StringLength(32)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Column("password")]
        [StringLength(32)]
        public string Password { get; set; }

        [Column("phone_number")]
        [StringLength(16)]
        public string PhoneNumber { get; set; }

        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }

        [Column("gender")]
        [StringLength(1)]
        public char? Gender { get; set; }

        [Column("hobby")]
        [StringLength(128)]
        public string Hobby { get; set; }

        [Column("levels")]
        [StringLength(32)]
        public string Levels { get; set; }

        [Column("tests")]
        [StringLength(32)]
        public string Tests { get; set; }

        [Column("accents")]
        [StringLength(32)]
        public string Accents { get; set; }

        [Column("directions")]
        [StringLength(128)]
        public string Directions { get; set; }

        [Column("photo")]
        [StringLength(64)]
        public string Photo { get; set; }
    }
}
