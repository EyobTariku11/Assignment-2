using System;


namespace Assignment_2
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\t---------------------------------------------");
            Console.WriteLine("\t\t\t\t\t-WELCOME TO GRADE CALCULATOR-");
            Console.WriteLine("\t\t\t\t---------------------------------------------");

            int n;
            Console.WriteLine();
            Console.WriteLine("HOW MANY STUDENT YOU WANT TO ADD??");
            n = Convert.ToInt32(Console.ReadLine());

            //declare array
            string[] name;
            name = new string[n];

            string[] coursename;
            coursename = new string[n];

            int[] age;
            age = new int[n];

            double[] aver;
            aver = new double[n];

            //GET DATA 
            for (int i = 0; i < n; i++)
            {
                //NAME
                Console.WriteLine("ENTER NUMBER " + (i + 1) + " STUDENT NAME");
                name[i] = Console.ReadLine();

                //AGE
                Console.WriteLine("ENTER NUMBER " + (i + 1) + " STUDENT AGE");
                age[i] = Convert.ToInt32(Console.ReadLine());
                while (age[i] < 0)
                {
                    Console.WriteLine("ERROR Age must be a positive number ");
                    age[i] = Convert.ToInt32(Console.ReadLine());
                }

                //COURSE
                Console.WriteLine("ENTER NUMBER " + (i + 1) + " STUDENT TAKING COURSE NAME");
                coursename[i] = Console.ReadLine();

                //GRADE
                Console.WriteLine("ENTER NUMBER " + (i+1) + " STUDENT AVERAGE OF COURSE " + coursename[i]);
                aver[i] = Convert.ToDouble(Console.ReadLine());
                while (aver[i] < 0 || aver[i] > 100)
                {
                    Console.WriteLine("ERROR Grade must be greater than zero and lessthan hundred ");
                    aver[i] = Convert.ToDouble(Console.ReadLine());
                }

                // DISPLAY DATA
                Console.WriteLine();
                Console.WriteLine("\tSUMMARY");
                Console.WriteLine("\t-------");

                Console.WriteLine(" \tID:" + (i + 1) + "\n \tNAME:" + name[i] + " \n \tAGE:" + age[i] + "\n \tCOURSE:" + coursename[i] + "\n \tAVERAGE:" + aver[i]);
                Console.WriteLine();

                //CONDITIONS
                if (aver[i] < 50)
                {
                    Console.WriteLine("STUDENTS GRADE IS F");
                    Console.WriteLine();
                }
                else if (aver[i] > 50 && aver[i] < 60)
                {
                    Console.WriteLine("STUDENTS GRADE IS C");
                    Console.WriteLine();
                }
                else if (aver[i] > 60 && aver[i] < 80)
                {
                    Console.WriteLine("STUDENTS GRADE IS B");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("STUDENTS GRADE IS A");
                    Console.WriteLine();
                }
                if (n > 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("PRESS ANY KEY TO ADD THE NEXT STUDENT");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("PRESS ANY KEY TO EXIT");
                    Console.ReadKey();
                }

            }


        }

    }
}

