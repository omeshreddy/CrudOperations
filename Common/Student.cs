namespace CrudOperations.Common
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public char StudentGrade { get; set; }
        public Employee ClassTeacher { get; set; }
    }
}
