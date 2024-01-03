using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace PracticeJan2_2PM
{

   public static class A
    {
       public static string n = "suresh";
       public static void M1(this student a,int s)
        {
            Console.WriteLine("Student grade "+s);
        }
    }
    public partial class p
    {
        p() 
        {
            Console.WriteLine("class 1 constructor");
        }
       public void M1(int a)
        {

        }
    }
    public partial class p
    {
        public void M1(string a)
        {
            Console.WriteLine("Class 2 Method");
        }

    }
    public partial class p
    {
        static void Main(string[] args)
        {
            p x = new p();
            x.M1(5);
            x.M1("suresh");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(A.n);
            //A.M1(5);
            student x = new student();
            x.Id(1);
            x.Name("Suresh");
            x.M1(2);
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Reverse of {n} is "+x.reverse(n));//revser method is extention method from Stdent class it is working like packages in java
            Console.WriteLine("enter a String");
            string s=Console.ReadLine();
            Console.WriteLine("Reverse of string "+student.Reverse(s));
        }
    }
}
