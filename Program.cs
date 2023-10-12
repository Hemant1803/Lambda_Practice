namespace Student_Data_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() {Id = 1, Name = "Hemaant", Age = 27, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 85},
                new Student() {Id = 2, Name = "Yash", Age = 19, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 82},
                new Student() {Id = 3, Name = "Deepak", Age = 18, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 90},
                new Student() {Id = 4, Name = "Priya", Age = 17, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 95},
                new Student() {Id = 5, Name = "Manoj", Age = 16, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 65},
                new Student() {Id = 6, Name = "Rishi", Age = 15, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 74},
                new Student() {Id = 7, Name = "Prince", Age = 14, Address = "Delhi", PhoneNumber = 123456789 , TotalMarks = 50},
            };
            Console.WriteLine("All Students Details");
            DisplayStudents(students);

            var Students12to18 = students.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
            Console.WriteLine("Students aged between 12 and 18:");
            DisplayStudents(Students12to18);

            var descendingorder = students.OrderByDescending(s => s.TotalMarks).ToList();
            Console.WriteLine("\nStudents sorted by TotalMarks (descending order):");
            DisplayStudents(descendingorder);

            var firstThreeStudents = students.Take(3).ToList();
            Console.WriteLine("\nFirst three students:");
            DisplayStudents(firstThreeStudents);
           
            string searchName = "Manoj";
            var foundStudent = students.FirstOrDefault(s => s.Name == searchName);
            if (foundStudent != null)
            {
                Console.WriteLine($"\nStudent found with name '{searchName}':");
                DisplayStudent(foundStudent);
            }
            else
            {
                Console.WriteLine($"\nNo student found with name '{searchName}'.");
            }
        
    }
        static void DisplayStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                DisplayStudent(student);
            }
        }

        static void DisplayStudent(Student student)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}, TotalMarks: {student.TotalMarks}");
        }
    }

}