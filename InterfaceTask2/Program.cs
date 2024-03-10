using InterfaceTask2.Models;

namespace InterfaceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Kamran1998");
            Console.WriteLine(user.Password);

        }
    }
}
