using System.Text.RegularExpressions;

namespace User_Registration
{
    internal class Program
    {
        static void CreateUser()
        {
            Regex exp1 = new Regex(@"\b[A-Z]+\w{2,}");

            Console.WriteLine("Enter First Name: ");
            string Fname = Console.ReadLine();

            if (exp1.IsMatch(Fname))
            {
                User user = new User(Fname);
                Console.WriteLine("User Created");
            }
            else
            {
                Console.WriteLine("Enter valid user First Name");
            }
        }
        static void Main(string[] args)
        {
            CreateUser();
        }
    }
}