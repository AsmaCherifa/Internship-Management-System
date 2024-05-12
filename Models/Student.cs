using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Internship_Management_System.Models
{
    [Table("Student")]

    public class Student
    {
        [Key]
        [Display(Name = "ID")]
        public int studentId { get; set; }



        [Required]
        [Display(Name = "Student Name")]
        [Column(TypeName = "varchar(50)")]
        public string studentName { get; set; } = string.Empty;


        [Display(Name = "Image Student")]
        [Column(TypeName = "varchar(250)")]
        public string? ImageUser { get; set; }


        [Required]
        [Display(Name = "National ID")]
        [MaxLength(8)]
        [MinLength(8)]
        [Column(TypeName = "varchar(8)")]
        public string NationalId { get; set; }


        [Display(Name = "email Student")]
        [Column(TypeName = "varchar(50)")]
        public string? email { get; set; }


        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [Required]
        [Display(Name = "Phone Number")]
        [MaxLength(8)]
        [MinLength(8)]
        [Column(TypeName = "varchar(8)")]
        public string phone { get; set; }

      }

}
