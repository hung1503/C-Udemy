namespace Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Bob","No", 19, 89);
            s1.Name = "Frank";
            Console.WriteLine(s1.Name);
            s1.Age = 20;
            Console.WriteLine(s1.Age);
            s1.FinalGrade = 66;
            Console.WriteLine(s1.FinalGrade);
            Console.WriteLine(s1.LastName);

            //Student s2 = new Student("Frank", 19, 99);
            //s2.SayHello();
            //s2.SetName("");
            //Console.WriteLine(s2.GetName());
        }
    }
}