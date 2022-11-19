namespace Section5
{
    class Program
    {
        static void Main(string[] args)
        {   //1
            // Pass by value
            //int studentGrade1 = 75;
            //Console.WriteLine("Before {0}", studentGrade1);
            //GiveExtraCredit(studentGrade1);
            //Console.WriteLine("After {0}", studentGrade1);

            //2
            // Pass by reference
            //int[] grades = new int[1];
            //grades[0] = 80;
            //Console.WriteLine("Before {0}", grades[0]);
            //GiveExtraCreditArray(grades);
            //Console.WriteLine("After {0}", grades[0]);

            //3
            //int studentGrade = 75;
            //GiveExtraCredit(ref studentGrade); // Using ref keyword can force the value change
            //Console.WriteLine(studentGrade);

            //4 out keyword can also force the value change and the value doesnt need initial value
            //int add;
            //int mult;
            //AddAndMult(5, 10, out add, out mult);
            //Console.WriteLine(add);
            //Console.WriteLine(mult);

            //5 Params
            //int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //PrintArray(myArray);
            //PrintArray(1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            //6 Method Overloading
            //Add(5, 6);
            //Add("Hello", "World");
            //Add(5.5, 6.9);

            //7
            //Add(5); // parameter is x
            //Add(5, 9); // parameter is x and y
            //Add(5, z: 5); // Overwrite z in Add method

            // Exercise 1
            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //MultiplicationTable(number);

            // Exercise 2
            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //int squareNum = SquareNumber(number);
            //int cubeNum = CubeNumber(number);
            //Console.WriteLine("the square of the number is {0}", squareNum);
            //Console.WriteLine("the cube of the number is {0}", cubeNum);

            // Exercise 3
            int[] numberList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Sum(1, 2, 3);
            Sum(1, 2, 3, 4, 5);
            Sum(numberList);

        }
        //1
        //public static void GiveExtraCredit(int studentGrade)
        //{
        //    studentGrade += 3;
        //}

        //2
        //public static void GiveExtraCreditArray(int[] grades)
        //{
        //    grades[0] += 3;
        //}

        //3
        //public static void GiveExtraCredit(ref int studentGrade)
        //{
        //    studentGrade += 3;
        //}

        //4
        //public static void AddAndMult(int a, int b, out int added, out int mult)
        //{
        //    added = a + b;
        //    mult = a * b;
        //}

        //5
        //public static void PrintArray(params int[] array)
        //{
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}

        //6 
        //public static void Add(int x, int y)
        //{
        //    int answer = x + y;
        //    Console.WriteLine(answer);
        //}

        //public static void Add(string x, string y)
        //{
        //    string answer = x + " " + y;
        //    Console.WriteLine(answer);
        //}

        //public static void Add(double x, double y)
        //{
        //    double answer = x + y;
        //    Console.WriteLine(answer);
        //}

        //7
        //public static void Add(int x, int y = 5, int z = 3)
        //{
        //    int answer = x + y + z;
        //    Console.WriteLine(answer);
        //}

        //Exercise 1
        //public static void MultiplicationTable(int x)
        //{
        //    for(int i = 2; i<11; i++)
        //    {
        //        int result = x * i;
        //        Console.WriteLine("{0} * {1} = {2}", x, i, result);
        //    }
        //}

        // Exercise 2
        //public static int SquareNumber(int x)
        //{
        //    return x * x;
        //}
        //public static int CubeNumber(int x)
        //{
        //    int squareNum = SquareNumber(x);
        //    return x * squareNum;
        //}

        // Exercise 3
        public static void Sum(params int[] num)
        {
            int sum = 0;
            for(int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine(sum);
        }
    }
}