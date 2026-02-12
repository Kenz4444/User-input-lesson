using System.Transactions;

namespace User_input_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //practice one
            string username;

            Console.Write("Enter username: ");
            Console.Write("");
            username = Console.ReadLine();
            Console.WriteLine("Your username is " + username);
            Console.ReadLine();

            //practice two
            int age;
            Console.Write("Enter your age: ");
            Console.Write("");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine() ;

            //practice three
            double price;
            
            Console.Write("What is the price?");
            Console.Write("");
            double.TryParse(Console.ReadLine(),out price);
           
            Console.WriteLine("The price is " + price.ToString("C"));



        }
    }
}
