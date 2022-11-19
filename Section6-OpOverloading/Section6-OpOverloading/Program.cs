using Section6_OpOverloading;

namespace OpOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount(100, "Bob");
            BankAccount bank2 = new BankAccount(200, "Annie");

            BankAccount bank3 = bank1 + bank2;
            Console.WriteLine(bank3.Owner);
            Console.WriteLine(bank3.Money);

            BankAccount bank4 = bank3 + 500;
            Console.WriteLine(bank4.Owner);
            Console.WriteLine(bank4.Money);
        }
    }
}