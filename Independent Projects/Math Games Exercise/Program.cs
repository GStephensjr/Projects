using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Games_Exercise
{
    class Program
    {
        public static Random random = new Random();
        public static string grade;
        public static double correct;
        public static Divvy result;
        static void Main()
        {
            correct = 0;
            Console.WriteLine("Welcome to the Math Games");
            Console.WriteLine("Brought to you by GStephensJr©");
            Console.WriteLine();
            Console.WriteLine("Select the game you want to play: \n" +
                "1. Add \n" +
                "2. Subtract \n" +
                "3. Multiply \n" +
                "4. Divide");
            string choice = Console.ReadLine();
            if (choice == "1")
                Add();
            if (choice == "2")
                Subtract();
            if (choice == "3")
                Multiply();
            if (choice == "4")
                Divide();
            else
                Reset();
            Reset();
        }
       public static void Add()
        {
            double iter = howMany();
            for(int i = 0; i < iter; i++)
            {
                int a = random.Next(0, 10);
                int b = random.Next(0, 10);
                int correctanswer = a + b;
                Console.WriteLine($"{a}+{b}?");
                int useranswer = Convert.ToInt32(Console.ReadLine());
                if (correctanswer == useranswer)
                {
                    correct++;
                    Console.WriteLine("Correct");
                }
                else
                    Console.WriteLine("Incorrect");
            }
            Grading(correct, iter);
        }
        public static void Subtract()
        {
            double iter = howMany();
            for (int i = 0; i < iter; i++)
            {
                int a = random.Next(0, 10);
                int b = random.Next(0, 10);
                int correctanswer = a - b;
                Console.WriteLine($"{a}-{b}?");
                int useranswer = Convert.ToInt32(Console.ReadLine());
                if (correctanswer == useranswer)
                {
                    correct++;
                    Console.WriteLine("Correct");
                }
                else
                    Console.WriteLine("Incorrect");
            }
            Grading(correct, iter);

        }
        public static void Multiply()
        {
            double iter = howMany();
            for (int i = 0; i < iter; i++)
            {
                int a = random.Next(0, 10);
                int b = random.Next(0, 10);
                int correctanswer = a * b;
                Console.WriteLine($"{a}*{b}?");
                int useranswer = 0;
                useranswer = Convert.ToInt32(Console.ReadLine());
                if (correctanswer == useranswer)
                {
                    correct++;
                    Console.WriteLine("Correct");
                }
                else
                    Console.WriteLine("Incorrect");
            }
            Grading(correct, iter);

        }

        public static void Divide()
        {
            double iter = howMany();

            for (int i = 0; i < iter; i++)
            {
                divCheck();
                Console.WriteLine($"{result.first}/{result.second}?");
                int useranswer = 0;
                useranswer = Convert.ToInt32(Console.ReadLine());
                if (result.right == useranswer)
                {
                    correct++;
                    Console.WriteLine("Correct");
                }
                else
                    Console.WriteLine("Incorrect");
            }
            Grading(correct, iter);

        }
        public static void divCheck()
        {
            double a = random.Next(1, 10);
            double b = random.Next(1, 10);
            double correct = a / b;
            if ((correct % 1) == 0)
                result = new Divvy { first = Convert.ToInt32(a), second = Convert.ToInt32(b), right = Convert.ToInt32(correct) };
            else
                divCheck();

        }
        public static int howMany()
        {
            
            Console.Write("Enter the desired amount of questions: ");
            int iter = Convert.ToInt32(Console.ReadLine());
            if(iter > 10)
            {
                Console.WriteLine("amount of questions cannot be greater than 10");
                Pause();
                howMany();
            }
            else if(iter < 1)
            {
                Console.WriteLine("amount of questions must be greater than 0");
                Pause();
                howMany();
            }
            return iter;
        }
        public static void Pause()
        {
            Console.Write("Press any key to continue . . .");
            Console.ReadKey(true);
        }
        public static void Reset()
        {
            Pause();
            Console.Clear();
            Main();
        }
        public static void Grading(double correct, double iter)
        {
            double percent = (correct / iter) * 100;
            if (percent >= 90)
                grade = "A";
            else if (percent >= 80)
                grade = "B";
            else if (percent >= 70)
                grade = "C";
            else if (percent >= 60)
                grade = "D";
            else if (percent < 60)
                grade = "F";
            Console.WriteLine($"You earned a {percent}% [{grade}]");
        }
        public class Divvy
        {
            public int first;
            public int second;
            public int right;
        }
    }
}
