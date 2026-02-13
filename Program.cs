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
            Console.ReadLine();

            //practice three
            double price;

            Console.Write("What is the price?");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The price is " + (price * 0.2).ToString("C"));

            //task one
            string pizzaTopping;
            string usersName;
            Console.Write("Enter your favourite pizza topping: ");
            Console.Write("");
            pizzaTopping = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your name:");
            Console.Write("");

            usersName = Console.ReadLine();
            Console.WriteLine("Thats so cool " + usersName + "! My name is Kenzie and I also like " + pizzaTopping + " on my pizza!");

            //task two
            string itemName;
            double itemPrice;

            Console.Write("Enter the name of an item: ");
            Console.Write("");
            itemName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the price of the item: ");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out itemPrice);
            Console.WriteLine();
            Console.WriteLine("To buy three " + itemName + " it will cost " + (itemPrice * 3).ToString("C"));

            //Task three
            double circleDiameter;


            Console.Write("Enter the diameter of a circle without units: ");

            Console.Write("");
            double.TryParse(Console.ReadLine(), out  circleDiameter);
            Console.WriteLine("The radius of a circle with a diameter of " + circleDiameter + " is " + (circleDiameter / 2));



        }
    }
}
