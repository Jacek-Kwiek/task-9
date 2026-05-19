namespace TASK_9.ModelExtensions
{
    public partial class Student
    {
        public string FullName => $"{FirstName} {LastName}";

        public bool HasAcademicEmail()
        {
            return Email.EndsWith("@students.example.edu", StringComparison.OrdinalIgnoreCase);
        }
    }
}
