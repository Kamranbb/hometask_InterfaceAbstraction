using InterfaceTask2.Models;

namespace InterfaceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Kamran1998", "Kamran Baxsaliyev","kamran.baxsaliyev98@mail.ru");
            Console.WriteLine(user.Password);
            user.ShowInfo();

        }
    }
}
