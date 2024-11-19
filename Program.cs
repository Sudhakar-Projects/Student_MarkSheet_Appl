using System;
namespace Marksheet_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Roll no");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter your Class");
            string standard = Console.ReadLine();
            Console.WriteLine("Enter Hindi Marks");
            int hindi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter English Marks");
            int english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Math Marks");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics Marks");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Marks");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Biology Marks");
            int biology = int.Parse(Console.ReadLine());

            int total = hindi + english + math + physics + chemistry + biology;
            int percentage = total * 100 / 600;

            Console.WriteLine("---------MARKSHEET--------");
            Console.WriteLine("Your Name is: {0}", name);
            Console.WriteLine("Your Roll no is; {0}", roll);
            Console.WriteLine("Tour Class is: {0}", standard);
            Console.WriteLine("Your obtained mark are {0}", total);
            Console.WriteLine("Your percentage is {0}", percentage);

            // if else if for grade
            if (percentage >= 80)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 40) 
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("Grade: E");
            }
            else
            {
                Console.WriteLine("Grade: F (Fail)");
            }

            // if else if for remark
            if (percentage >= 80)
            {
                Console.WriteLine("Remarks: Excellent !!");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Remarks: Vary Good !!");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Remarks: Good !!");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Remarks: Fair !!");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Remarks: Poor !!");
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("Remarks: Needs lot of improvement !!");
            }
            else
            {
                Console.WriteLine("Remarks: Bring your parents tomorrow !!");
            }

            //  int total = hindi + english + math + physics + chemistry + biology;
            int result = 0;

            if (hindi < 35)
            {
                result++;
            }
            if (english < 35)
            {
                result++;
            }
            if (math < 35)
            {
                result++;
            }
            if (physics < 35)
            {
                result++;
            }
            if (chemistry < 35)
            {
                result++;
            }
            if (biology < 35)
            {
                result++;
            }

            Console.WriteLine("You are failed in {0} Subjects",result);

            Console.ReadLine();
        }
    }
}