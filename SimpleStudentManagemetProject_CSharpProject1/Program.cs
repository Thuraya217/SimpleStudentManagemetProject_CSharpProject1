using System;

namespace SimpleStudentManagemetProject_CSharpProject1
{
    internal class Program
    {
        static double[] marks = new double[10];
        static int[] Ages = new int[10];
        static string[] names = new string[10];
        static DateTime[] dates = new DateTime[10];
        static int StudentCount = 0;

        // Simple Calculator
        static void SimpleCalculator()
        {
            double[] marks = new double[10];
            Console.WriteLine("student list");

            StudentCount++;
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
                    case 2: ViewAllStudents(); break;
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
                char choice;

                Console.Clear();
                Console.WriteLine("enter student names, ages, markes:");

                while (StudentCount < 10)
                {

                    Console.WriteLine("Enter name of Student:");
                    string name = Console.ReadLine();
                    names[StudentCount] = name;

                    Console.WriteLine("Enter age of Student > 21 :");
                    int age = int.Parse(Console.ReadLine());
                    Ages[StudentCount] = age;

                    if (age <= 21)
                    {
                        Console.WriteLine("invalid age student must be older than 21");
                        return;
                    }

                    Console.WriteLine("Enter marke of Student (0-100):");
                    double mark = double.Parse(Console.ReadLine());
                    marks[StudentCount] = mark;

                    if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("invalid mark must be between 0 and 100");
                        return;
                    }

                    Console.WriteLine("Student is add");
                    StudentCount++;

                    Console.WriteLine("Do you want another operation ? y / n");
                    choice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (choice != 'y' && choice != 'Y')
                        break;
                }
                if (StudentCount == 11)
                    Console.WriteLine("Cannot add more student");

            }

            // View all students with formatted output and subject-wise marks
            static void ViewAllStudents()
            {
                int i;
                for (i = 0; i < StudentCount; i++)
                {
                    Console.WriteLine("");
                }
                {
                    Console.WriteLine("Student List " + (i + 1));
                    Console.WriteLine("names" + names[i]);
                    Console.WriteLine("marks" + marks[i]);
                    Console.WriteLine("ages" + Ages[i]);
                    Console.WriteLine("Date Time" + dates[i]);
                }
                Console.ReadLine();
            }

            // Find a student by name
            static void FindAStudentByName()
            {
                Console.WriteLine("Enter name of student to search:");
                string SearchName = Console.ReadLine();

                int i;

                for (i = 0; i < StudentCount; i++)
                {
                    if (names[i] == SearchName)
                    {
                        Console.WriteLine("Student List " + (i + 1));
                        Console.WriteLine("names" + names[i]);
                        Console.WriteLine("marks" + marks[i]);
                        Console.WriteLine("ages" + Ages[i]);
                        Console.WriteLine("Date Time" + dates[i]);
                    }
                    Console.ReadLine();
                }
            }

            // Calculate the class average
            static void CalculateTheClassAverage()
            {
                Console.WriteLine("Calculate the class Average:");

                double sum = 0;
                for (int i = 0; i < Ages.Length; i++)
                {
                    sum = sum + marks[i];
                }
                double AverageMarks = sum / StudentCount;
                Console.WriteLine($"Average marks {Math.Round(AverageMarks, 2)}");
            }

            // Find the top-performing student
            static void FindTheTopPerformingStudent()
            {
                Console.WriteLine("Find the Top Performing Student:");


                int IndexTopPerformance = 0;
                for (int i = 0; i < StudentCount; i++)
                {
                    if (marks[i] > IndexTopPerformance)
                    {
                        IndexTopPerformance = i;
                    }
                }

                Console.WriteLine("Top Student:" + names[IndexTopPerformance] + marks[IndexTopPerformance] + Ages[IndexTopPerformance]);
            }

            // Sort students by marks
            static void SortStudentsByMarks()
            {
                Console.WriteLine("Sort Students by Marks:");
                Array.Sort(marks, names);
                for (int i = 0; i < StudentCount; i++)
                {
                    Console.WriteLine("Student List " + (i + 1));
                    Console.WriteLine("names" + names[i]);
                    Console.WriteLine("marks" + marks[i]);
                    Console.WriteLine("ages" + Ages[i]);
                    Console.WriteLine("Date Time" + dates[i]);
                }
                Console.ReadLine();
            }

            // Delete a student record
            static void DeleteAStudentRecord()
            {
                Console.WriteLine("Delete a Student");
                String DeleteName = Console.ReadLine();

                for (int i = 0; i < StudentCount; i++)
                {
                    if (names[i] == DeleteName) ;
                }

            }
        }
    }
}




