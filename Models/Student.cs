using System.ComponentModel.DataAnnotations;

namespace StudentCrudApiWithEFCore.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        [Required]
        public string studentName { get; set; }

        [Required]
        public string studentDepartment { get; set; }
    }
}
