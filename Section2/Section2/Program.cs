namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your year");
            //int year = int.Parse(Console.ReadLine());
            //// switch statement
            //switch(year)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Freshmen");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Sophomore");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("Junior");
            //            break;
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine("Senior");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Invalid year");
            //            break;
            //        }
            //}

            // (condition) ? true : false

            //Exercise 1

            //Console.WriteLine("Enter the hourly pay rate:");
            //double payRate = double.Parse(Console.ReadLine());
            //if (payRate < 7.50 || payRate > 49.0)
            //{
            //    Console.WriteLine("Invalid!");
            //}
            //else
            //{
            //    Console.WriteLine("Valid pay rate");
            //}


            // Exercise 2
            //Console.WriteLine("Enter length:");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter width:");
            //double width = double.Parse(Console.ReadLine());
            //double area = length * width;
            //if(area < 400)
            //{
            //    double price = 25 * 20;
            //    Console.WriteLine("the area for lawn-mowing is {0} under 400 quare feet, the price is 25$/week", area);
            //    Console.WriteLine("the total price is {0}", price);
            //}
            //else if (area > 600)
            //{
            //    double price = 50 * 20;
            //    Console.WriteLine("the area for lawn-mowing is {0} over 600 quare feet, the price is 50$/week", area);
            //    Console.WriteLine("the total price is {0}", price);
            //}
            //else
            //{
            //    double price = 35 * 20;
            //    Console.WriteLine("the area for lawn-mowing is {0} under 400 quare feet, the price is 35$/week", area);
            //    Console.WriteLine("the total price is {0}", price);
            //}


            // Exercise 3
            Random randomGen = new Random();
            int randomNumber = randomGen.Next(1, 10);

            Console.WriteLine("Enter your number");
            int numberInput = int.Parse(Console.ReadLine());

            if(numberInput > randomNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (numberInput == randomNumber)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Too low");
            }
            Console.WriteLine("the number is {0}", randomNumber);
        }
    }
}