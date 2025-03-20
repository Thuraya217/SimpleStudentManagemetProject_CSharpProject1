using System;

namespace SimpleStudentManagemetProject_CSharpProject1
{
    internal class Program
    {
        static double[] marks = new double[100];
        static int[] Ages = new int[100];
        static string[] names = new string[100];
        static DateTime[] dates = new DateTime[100];
        static int StudentCounter = 0;

        // Simple Calculator
        static void SimpleCalculator()
        {
            double[] marks = new double[10];
            Console.WriteLine("student list");

            StudentCounter++;
            for (int i = 0; i < 3; i++) ;
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(marks[i]);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Add a new student record");
                Console.WriteLine("2. View all students with formatted output and subject-wise marks");
                Console.WriteLine("3. Find a student by name");
                Console.WriteLine("4. Calculate the class average");
                Console.WriteLine("5. Find the top-performing student");
                Console.WriteLine("6. Sort students by marks");
                Console.WriteLine("7. Delete a student record");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddANewStudenRecord(); break;
                    case 2: ViewAllStudentsWithFormattedOutputAndSubjectWiseMarks(); break;
                    case 3: FindAStudentByName(); break;
                    case 4: CalculateTheClassAverage(); break;
                    case 5: FindTheTopPerformingStudent(); break;
                    case 6: SortStudentsByMarks(); break;
                    case 7: DeleteAStudentRecord(); break;
                    case 8: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();
            }

            // Add a new student record
            static void AddANewStudenRecord()
            {
                Console.Clear();
                Console.WriteLine("enter student names, ages, markes:");

                int StudentList = int.Parse(Console.ReadLine());
                switch (StudentList)
                {
                    case 1:
                        Console.WriteLine("1- enter student names");
                        break;

                    case 2:
                        Console.WriteLine("2- enter student ages");
                        break;

                    case 3:
                        Console.WriteLine("3- enter student marks");
                        break;

                    case 4:
                        Console.WriteLine("4- Exit the program");
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

            if (StudentCounter >= 100)
                {
                    Console.WriteLine("Add more Student:");
                    return;
                }
                Console.WriteLine("Enter name of Student:");
                string names = Console.ReadLine();

                Console.WriteLine("Enter age of Student > 21 :");
                int ages = int.Parse(Console.ReadLine());

                if (ages <= 21)
                {
                    Console.WriteLine("invalid age student must be older than 21");
                    return;
                }

                Console.WriteLine("Enter marke of Student (0-100):");
                double markes = double.Parse (Console.ReadLine());

                //if (marks < 0 || marks > 100)
                //{
                //    Console.WriteLine("invalid mark must be between 0 and 100");
                //    return;
                //}
                //names[StudentCounter] = names;
                //ages[StudentCounter] = ages;
                //marks[StudentCounter] = marks;

                //StudentCounter++
                Console.WriteLine("Student is add");
            }

            // View all students with formatted output and subject-wise marks
            static void ViewAllStudentsWithFormattedOutputAndSubjectWiseMarks()
            {


            }

            // Find a student by name
            static void FindAStudentByName()
            {


            }

            // Calculate the class average
            static void CalculateTheClassAverage()
            {


            }

            // Find the top-performing student
            static void FindTheTopPerformingStudent()
            {


            }

            // Sort students by marks
            static void SortStudentsByMarks()
            {


            }

            // Delete a student record
            static void DeleteAStudentRecord()
            {


            }
        }
    }
}
