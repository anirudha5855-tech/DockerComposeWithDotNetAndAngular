using System.ComponentModel.DataAnnotations;

namespace CoreApisWithDatabase.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string StudentName{ get; set; }
        public  string Qualification{ get; set; }
        public float Percentage { get; set; }
    }
}
