
//C# program to create marksheet for students Using If Statement.
//using System;

//int r, marks;
//string n;

//Console.WriteLine("Enter Student Roll Number :");
//r = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Student Name :");
//n = Console.ReadLine();

//Console.WriteLine("Enter Marks :");
//marks = Convert.ToInt32(Console.ReadLine());

//if (marks >= 80 && marks < 100)
//{
//    Console.WriteLine("You Got A Grade");
//}
//if (marks >= 60 && marks < 80)
//{
//    Console.WriteLine("You Got B Grade");
//}
//if (marks >= 40 && marks < 60)
//{
//    Console.WriteLine("You Got C grade");
//}
//if (marks <= 33 && marks < 40)
//{
//    Console.WriteLine("You Got D Grade");
//}





//using System;

//namespace Conditional
//{
//    class Nested
//    {
//        public static void Main(string[] args)
//        {
//            int first = 7, second = -23, third = 13;
//            if (first > second)
//            {
//                if (first > third)
//                {
//                    Console.WriteLine("{0} is the largest", first);
//                }
//                else
//                {
//                    Console.WriteLine("{0} is the largest", third);
//                }
//            }
//            else
//            {
//                if (second > third)
//                {
//                    Console.WriteLine("{0} is the largest", second);
//                }
//                else
//                {
//                    Console.WriteLine("{0} is the largest", third);
//                }
//            }
//        }
//    }
//}




//using System;
/*public class ifelse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check grade in 100:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0 || num > 100)
        {
            Console.WriteLine("wrong number");
        }
        else if ( num >= 0 && num < 33 )
        {
            Console.WriteLine("You Are Fail");
        }
        else if ( num >= 33 && num < 50 )
        {
            Console.WriteLine("You Are Achive Grade E");
        }
        else if ( num >= 50 && num < 60)
        {
            Console.WriteLine("You Are Achive Grade D");
        }
        else if (num >= 60 && num < 65)
        {
            Console.WriteLine("You Are Achive Grade D+");
        }
        else if (num >= 65 && num < 70)
        {
            Console.WriteLine("You Are Achive Grade C");
        }
        else if (num >= 70 && num < 80)
        {
            Console.WriteLine("You Are Achive Grade C+");
        }
        else if (num >= 80 && num < 85)
        {
            Console.WriteLine("You Are Achive Grade B");
        }
        else if (num >= 85 && num < 90)
        {
            Console.WriteLine("You Are Achive Grade B+");
        }
        else if (num >= 90 && num < 95)
        {
            Console.WriteLine("You Are Achive Grade A");
        }
        else if (num >= 95 && num < 100)
        {
            Console.WriteLine("You Are Achive Grade A+");
        }
        Console.ReadLine();
    }
}*/
/*using System;
public class nestedif
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Email");
        string email = Console.ReadLine();

        if (email == "zohaib786@gmail.com")
        {
            Console.WriteLine("Give A Password");
            string password = Console.ReadLine();
            if (password == "123456")
            {
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();

                if (name == "Zohaib Ali")
                {
                    Console.WriteLine("Wellcome Zohaib Salamat Ali");
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Name OtherWise GoToHell");
                }
            }
            else
            {
                Console.WriteLine("Invaild Password");
            }
        }
        else
        {
            Console.WriteLine("Invaild Email");
        }
        Console.ReadLine();
    }
}*/

//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int i = 0, n, count = 0, sum = 0;

//        Console.WriteLine("Enter The Value of n");
//        n = Convert.ToInt32(Console.ReadLine());
//        if (n <= 100)
//        {
//            Console.WriteLine("Good Number");
//            while (i <= n)
//            {
//                Console.WriteLine(i);
//                i++;
//            }
//            while (count < n)
//            {
//                sum = sum + (count + 1);
//                count++;
//            }
//            Console.WriteLine("Total sum =" + sum);
//            while (count < n)
//            {
//                count = (count + 1);
//                count++;
//            } 
//            Console.WriteLine("Total Number = " + count);

//        }
//        else
//        {
//            Console.WriteLine("Wrong Number");
//        }     
//        Console.ReadLine();
//    }
//}

//using System;

//class foreachloop
//{
//   static void Main(string[] args)
//    {
//        List<string> fruits = new List<string>() { "apple", "banana", "cherry" };
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }

//    }
//}

//using System;
//using System.Diagnostics.CodeAnalysis;

//public class Exercise9
//{
//    public static void Main()
//    {
//        int i, j, rows;


//        Console.Write("Input number of rows : ");
//        rows = Convert.ToInt32(Console.ReadLine());
//        for (i = 1; i <= rows; i++)
//        {
//            for (j = 1; j <= i; j++)
//                Console.Write("{0}", j);
//            Console.Write("\n");

//        }   
//    }
//}

//using System;

//public class Exercise1
//{
//    public static void Main()
//    {
//        int  n , rows;
//        Console.WriteLine("Give A Input : ");
//        n = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(i);
//            for (int j = 0; i < j; j += j)
//            {
//                Console.WriteLine( j );
//            }
//        }
//        Console.ReadLine();
//    }
//}

//using System;

//class Loops
//{
//    static void Main(string[] args)
//    {
//        int i, n, sum = 0;

//        Console.WriteLine("Input The Number : ");
//        n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("\nThe Even Number Are : ");

//        for (i = 1; i <= n; i++)
//        {
//            Console.WriteLine("{0}", 2 * i);
//            sum += 2 * i;
//        }
//        Console.WriteLine("\nThe Sum Even Natural Number Upto {0} : {1} \n", n, sum);
//    }
//}


//using System;
//public class Exercise31
//{
//    public static void Main()
//    {
//        int i, j, r, sum = 0, sum2 = 0;

//        Console.Write("Input number of rows (half of the diamond) :");
//        r = Convert.ToInt32(Console.ReadLine());
//        for (i = 0; i <= r; i++)
//        {
//            for (j = 1; j <= r - i; j++)
//                Console.Write(" ");
//            for (j = 1; j <= 2 * i - 1; j++)
//                Console.Write("*");
//            Console.Write("\n");
//            sum = sum + j;
//        }
//        for (i = r - 1; i >= 1; i--)
//        {
//            for (j = 1; j <= r - i; j++)
//                Console.Write(" ");
//            for (j = 1; j <= 2 * i - 1; j++)
//                Console.Write("*");
//            Console.Write("\n");
//            sum2 = sum2 + j;

//        }
//        Console.WriteLine("Total Sum : {0}", sum + sum2);
//    }
//}

//using System;
//class AllLoop
//{
//    static void Main(string[] args)
//    {
//        int i = 1;
//        int n = int.Parse(Console.ReadLine());


//        while ( i <= n)
//        {
//            Console.WriteLine(i);
//            n = 2 * n + 1;

//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Please Enter Your Name:");
//        string name = Console.ReadLine();
//        Console.WriteLine("Hello " + name + "! Nice to meet you");
//    }
//}



using System;

class TypeConversion
{
    static void Main(string[] args)
    {
        //Implicit Type Conversion Means Smaller Datatype Convert into Larger Datatype
        //byte b = 100;
        //int f = b + 50;
        //long l = f/(3*10);

        //Console.WriteLine(f);
        //Console.WriteLine(l);

        // Explicit Type Conversion Means Larger Datatype Convert into Smaller Datatype It is Called Casting
        double a = 500;
        int b = (int) a;
        Console.WriteLine(b);
    }
}
    


