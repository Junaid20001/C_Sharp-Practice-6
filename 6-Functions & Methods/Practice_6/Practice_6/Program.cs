using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Practice_6
{
    internal class Program
    {
        /*
        //public void Show()          //here I decleare my Method or Function &  Non-Static method  //non-parameterized method means no parameter in the bracket
        //{
        //    Console.WriteLine("Hello My Name is JK");
        //    Console.WriteLine("My Father name is Khalid");
        //}

        //public static void Show1()          //here I decleare my Method or Function &  Non-Static method
        //{
        //    Console.WriteLine("Hello My Name is FK");
        //    Console.WriteLine("My Father name is Khalid");
        //}

        static void Main(string[] args)
        {
            //Program p1 = new Program();
            //p1.Show();     //Call the non static methods & Functions
            //p1.Show();


            //Program.Show1();    //calling a static function 
           */

        //Parameter in the methods or functions
        //public static void Add(int num1, int num2)
        //{
        //    int result = num1 + num2;
        //    Console.WriteLine("Addition is : " + result);
        //}

        //new program 3.1.....
        //public static void ShowName(string name)
        //{
        //    Console.WriteLine("Your name is : " + name);
        //}

        //String & Int both parameter....
        //public static void Show_Name_Age(string name, int age)
        //{
        //    Console.WriteLine("My name is : " + name);
        //    Console.WriteLine("& I am " + age + " year old");
        //}

        //Return Function/Method parameter....
        //public static string Family_Name(string father_name)
        //{
        //    string result = "My father name is : " + father_name; //this method return the value of int
        //    return result;
        //}

        static void Main(string[] args)
        {

            //Program.Add(6, 17);   //Arguments
            //Program.Add(9, 11);

            //take value from user.....
            //Console.WriteLine("Enter first number : ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter second number : ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Program.Add(a, b);


            //new program 3.1.....
            //Console.WriteLine("Enter your Name : ");
            //string name = Console.ReadLine();

            //Program.ShowName(name);


            ////String & Int both parameter but in different position....
            //Console.WriteLine("Enter your name : ");
            //string my_name = Console.ReadLine();

            //Console.WriteLine("enter your age is : ");
            //int my_age = Convert.ToInt32(Console.ReadLine());

            //Program.Show_Name_Age(age:my_age, name:my_name);


            ////Return Function/Method parameter....

            //Console.WriteLine("Enter your father name : ");
            //string fmy_name = Console.ReadLine();

            //Console.WriteLine(Program.Family_Name(fmy_name)); 

            Console.ReadLine();
        }
    }
}
