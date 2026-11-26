namespace session3task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region session task
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade1");
            int grade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade2");
            int grade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade3");
            int grade3 = Convert.ToInt32(Console.ReadLine());

            int totaGrades = grade1 + grade2 + grade3;
            int avgGrade = totaGrades / 3;

            string status = (avgGrade >= 50) ? "Passed" : "Failed";
            string category = (age >= 18) ? "Adult" : "Minor";


            Console.WriteLine(string.Format("Student Name : {0}\nStudent Age : {1}\n", name, age));

            Console.WriteLine(string.Format("Total Grades : {0}\nAverage : {1}\n", totaGrades, avgGrade));

            Console.WriteLine(string.Format("Status : {0}\nCategory : {1}\n", status, category));

            #endregion
        }
    }
}
