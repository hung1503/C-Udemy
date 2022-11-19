// See https://aka.ms/new-console-template for more information

namespace Draft
{
    class Program
    {           
        enum DayOfWeek
            {
                SUNDAY,
                MONDAY,
                TUESDAY,
                WEDNESDAY,
                THURSDAY,
                FRIDAY,
                SATURDAY,
            }
        static void Main(string[] args)
        {
            string characterName = "Hung Nguyen";
            int characterAge = 22;
            char grade = 'A'; // Only a character is allowed
            double gpa = 3.6;
            bool isMale = true;
    
            DayOfWeek today = DayOfWeek.FRIDAY;
            int numberOfToday = (int)today;
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("My name is {0} and I am {1} years old", name, age);


            //Console.WriteLine("Enter the first number: ");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int secondNumber = int.Parse(Console.ReadLine());
            //int sum = firstNumber + secondNumber;
            //Console.WriteLine("We have the equation: {0} + {1} = {2}", firstNumber, secondNumber, sum);


            //Console.WriteLine("Enter the height: ");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width: ");
            //double width = double.Parse(Console.ReadLine());
            //double area = height*width;
            //const double pricePerSquare = 10.0;
            //double cost = area * pricePerSquare;
            //Console.WriteLine("We have the area: {0}*{1} = {2}, and the cost of the carpet: {2}*{3}={4}", height, width, area, pricePerSquare, cost);


            Console.WriteLine("Enter the time in minutes: ");
            int timeInput = int.Parse(Console.ReadLine());
            int hourResult = timeInput / 60;
            int minuteResult = timeInput % 60;
            Console.WriteLine("We have {0} minute(s) is equal to {1} hour(s) and {2} minute(s)", timeInput, hourResult, minuteResult );
        }
    }
}