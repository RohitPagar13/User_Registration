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

            Regex exp2 = new Regex(@"\b[A-Z]+\w{2,}");
            Console.WriteLine("Enter Last Name: ");
            string Lname = Console.ReadLine();

            Regex exp3 = new Regex(@"\b\w+\.?\w+?\@[a-z]+\.[a-z]+((?:.)[a-z]{1,})*");
            Console.WriteLine("Enter EMail: ");
            string email = Console.ReadLine().ToLower();

            Regex exp4 = new Regex(@"\b((\d{0,3})\s)?\d{6,10}");
            Console.WriteLine("Enter Mobile no: ");
            string no = Console.ReadLine();

            Regex exp5 = new Regex(@"\b[^\s].[^\s]{8,}}");
            Console.WriteLine("Enter Password: ");
            string pass = Console.ReadLine();

            if (!exp1.IsMatch(Fname))
            {
                Console.WriteLine("Enter valid user First Name");
                
            }
            else if (!exp2.IsMatch(Lname))
            {
                Console.WriteLine("Enter valid user Last Name");
            }
            else if (!exp3.IsMatch(email))
            {
                Console.WriteLine("Enter valid user Email");
            }
            else if (!exp4.IsMatch(no))
            {
                Console.WriteLine("Enter valid mobile no");
            }
            else
            {
                User user = new User(Fname, Lname);
                Console.WriteLine("User Created");
            }
        }
        static void Main(string[] args)
        {
            CreateUser();
        }
    }
}