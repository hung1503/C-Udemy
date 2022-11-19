using System.Xml.Schema;

namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myInt = 5;
            //int[] myArray = new int[3];
            //myArray[0] = 15;
            //myArray[1] = 03;
            //myArray[2] = 2000;

            //int[] myArray2 = new int[3] {15,03,2000};
            //int[] myArray3 = new int[] {15,03,2000};
            //int[] myArray4 = { 15, 03, 2000 };

            // FOR loop with array
            //int[] grades = { 66, 67, 68, 69, 70 };
            //for(int i = 0; i < grades.Length; i++)
            //{
            //    grades[i] += 3;
            //    Console.WriteLine(grades[i]);
            //}

            // FOREACH loop with array
            //int[] grades = { 66, 67, 68, 69, 70 };
            //foreach (int score in grades)
            //{
            //    Console.WriteLine(score);
            //}



            //string[] students = {"Peter", "Celine", "John", "Jodi"};
            //int[] grades = { 80, 94, 75, 96 };

            //Console.WriteLine("Enter the student's name to search:");
            //string studentName = Console.ReadLine();

            //bool contains = false;
            //int studentGrade = 0;
            //for(int i = 0; i < students.Length; i++)
            //{
            //    if(studentName == students[i])
            //    {
            //        contains = true;
            //        studentGrade = grades[i];
            //        break; // Stop the loop when the name is found
            //    }
            //}

            //if (contains)
            //{
            //    Console.WriteLine("The student is here");
            //    Console.WriteLine("The student's grade is {0}", studentGrade);
            //}
            //else 
            //{
            //    Console.WriteLine("The student is not in the data");
            //} 


            //BinarySearch
            //int[] myArray = { 10, 15, 20, 25, 30, 35, 40 }; // in order to make binary search works, the array must have to be in order
            //Console.WriteLine("Enter number to check if it exists:");
            //int number = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(myArray, number);
            //if(answer < 0)
            //{
            //    Console.WriteLine("The number is not exist");
            //} 
            //else
            //{
            //    Console.WriteLine("The number position in the array is {0}", answer);
            //}

            //Sorting an array
            //int[] myArray = { 10, 5, 7, 3, 6, 34 };
            //Array.Sort(myArray);
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            // Reverse an array
            //int[] myArray = { 10, 5, 7, 3, 6, 34 };
            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}



            //Multidimensional arrays

            //int[,] myArray = new int[3, 4]; // 3 rows 4 columns
            //myArray[0, 0] = 1;
            //myArray[0, 1] = 2;
            //myArray[0, 2] = 3;
            //myArray[0, 3] = 4;

            //myArray[1, 0] = 5;
            //myArray[1, 1] = 6;
            //myArray[1, 2] = 7;
            //myArray[1, 3] = 8;

            //myArray[2, 0] = 2;
            //myArray[2, 1] = 3;
            //myArray[2, 2] = 4;
            //myArray[2, 3] = 5;

            //int[,] myArray2 = {
            //    { 1, 2, 3, 4 },
            //    { 5, 6, 7, 8 },
            //    { 2, 3, 4, 5 }
            //};

            //for(int i = 0; i < 3 ; i++)
            //{
            //    for(int j = 0; j < 4 ; j++)
            //    {
            //        Console.Write(myArray[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[][] myArray = new int[3][];
            //myArray[0] = new int[4] {1,2,3,4};
            //myArray[1] = new int[5] {2,3,4,5,6};
            //myArray[2] = new int[6] {3,4,5,6,7,8};

            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < myArray[i].Length; j++)
            //    {
            //        Console.Write(myArray[i][j]);
            //    }
            //    Console.WriteLine();
            //}


            // Exercise 1
            //int[] zipCodes = { 65100, 65102, 65024, 66324, 63200, 64932, 63462, 62342, 62342, 65124 };
            //Console.WriteLine("Enter the zip code:");
            //int zipCodeInput = int.Parse(Console.ReadLine());
            //bool isExist = false;
            //for (int i = 0; i< zipCodes.Length; i++)
            //{
            //    if(zipCodes[i] == zipCodeInput)
            //    {
            //        isExist = true;
            //        break;
            //    }
            //}
            //if (isExist)
            //{
            //    Console.WriteLine("Found");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid zipcode");
            //}


            // Exercise 2
            //Console.WriteLine("Enter the amount of students");
            //int numberOfStudents = int.Parse(Console.ReadLine());
            //string[] studentNames = new string[numberOfStudents];
            //double[] studentGrades = new double[numberOfStudents];
            //double sumOfGrade = 0;
            //double hightestGrade = 0;
            //string highestGradeStudent = "";

            //for(int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.WriteLine("Enter the student name (index: {0}):", i + 1);
            //    string studentName = Console.ReadLine();
            //    studentNames[i] = studentName;
            //    Console.WriteLine("Enter the student grade (index: {0}):", i + 1);
            //    double studentGrade = double.Parse(Console.ReadLine());
            //    studentGrades[i] = studentGrade;
            //    sumOfGrade += studentGrade;

            //    if(studentGrade > hightestGrade)
            //    {
            //        hightestGrade = studentGrade;
            //        highestGradeStudent = studentName;
            //    }
            //}

            //double averageGrade = sumOfGrade / numberOfStudents;
            //Console.WriteLine("The highest grade in the class {0} and their name is {2} and the average grade is {1}", hightestGrade, averageGrade, highestGradeStudent);


            // Exercise 3
            string[] hiddenWords = { "string", "variable", "integer", "double", "array", "method", "statement", "length" };
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(0, 9);
            string theChosenWord = hiddenWords[randomNumber];
            int index = 0;
         
            while(theChosenWord == null)
            {
                for(int i = 0; i < theChosenWord.Length; i++)
                {
                    Console.Write("{0, 2}", "*");
                }
                Console.WriteLine("Enter a letter");
                char guess = char.Parse(Console.ReadLine());
                if (theChosenWord.Contains(guess))
                {
                    index = theChosenWord.IndexOf(guess);
                    
                }
            }

        }
    }
}