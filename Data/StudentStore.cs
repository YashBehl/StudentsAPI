using DemoWebAPI.Models;

namespace DemoWebAPI.Data
{
    public class StudentStore
    {
        public static List<Student> studentList = new List<Student>()
        {
            new Student() { studentID=1,studentName="Yash", studentAge=22, studentAddress = "Faridabad" },
            new Student() { studentID=2,studentName="Akshat", studentAge=21, studentAddress = "Delhi" },
            new Student() { studentID=3,studentName="Aman", studentAge=22, studentAddress = "Delhi" },
            new Student() { studentID=4,studentName="Varun", studentAge=23, studentAddress = "Gurgaon" }
        };
    }
}
