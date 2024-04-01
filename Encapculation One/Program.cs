using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("kAmIl " , "        qEhreManov     ");
            Console.WriteLine(user.Username);
            user.Password = "4655kl";
        }
    }
}
