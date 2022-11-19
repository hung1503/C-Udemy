// See https://aka.ms/new-console-template for more information
namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoWhile loop vs While loop

            //Console.WriteLine("Hello");
            //string response = Console.ReadLine();
            //while(response == "again")
            //{
            //    Console.WriteLine("Hello");
            //    response = Console.ReadLine();
            //}

            //string response; 
            //do
            //{
            //    Console.WriteLine("hello");
            //    response = Console.ReadLine();
            //} while (response == "again");

            // Nested loop
            //int size = 4;
            //for(int i = 0; i < size; i++)
            //{
            //    for(int x = 0; x< size; x++)
            //    {
            //        Console.Write("{0,-2}","*");
            //    }        
            //    Console.WriteLine();
            //}

            // Exercise 1
            //Console.WriteLine("Enter the payrate:");
            //double payRateInput = double.Parse(Console.ReadLine());
            //while(payRateInput > 49.99 || payRateInput < 5.65)
            //{
            //    Console.WriteLine("Enter the payrate again:");
            //    payRateInput = double.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The vaid payload is {0}", payRateInput);

            // Exercise 2
            //int sum = 0;
            //for(int i = 0; i<51; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);

            //Exercise 3
            //Random randomGenerator = new Random();
            //int randomNumber = randomGenerator.Next(1,11);
            //Console.WriteLine("Enter the random number from 1 to 10");
            //int numberInput = int.Parse(Console.ReadLine());
            //int count = 1;
            //while(numberInput != randomNumber)
            //{
            //    if(numberInput > randomNumber)
            //    {
            //        Console.WriteLine("The number is too high!");
            //    } 
            //    else if ( numberInput < randomNumber )
            //    {
            //        Console.WriteLine("The number is too low");
            //    }
            //    count++;
            //    Console.WriteLine("Enter the random number from 1 to 10");
            //    numberInput = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("You are correct, the answer is {0}", randomNumber);
            //Console.WriteLine("You try {0}", count);

        }
    }
}