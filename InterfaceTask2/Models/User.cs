using InterfaceTask2.Interface;
using System.Reflection.Metadata.Ecma335;



namespace InterfaceTask2.Models
{
    internal class User : IAccount
    {
        int _id; 
        public int Id { get => 145; }
        string _fullname;
        public string Fullname
        {
            get => _fullname;
            set
            {

            }
        }
        string _email;
        public string Email { get => _email;
          set 
            { 
            
            } 
        }
        string _password;
        public string Password
        {
            get {  return _password; }
            set
            {
                if (value.Length < 8) return;
                if (!(PasswordChecker(value))) return;
               
                _password = value;
                
            }
           
        }


          public bool PasswordChecker(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            foreach (char item in password)
            {
                if (char.IsLower(item))
                { 
                    isLower = true;
                }
                if (char.IsUpper(item))
                {
                    isUpper = true; 
                }
                if (char.IsDigit(item))
                {
                    isDigit = true;
                }
            }
            return isLower && isUpper && isDigit;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id : {Id} > FullName: {Fullname} > Email {Email}");
        }

        public User(string password,string fullname,string email)
        {
            Password = password;
            _email = email;
            _fullname = fullname;
           
           
        }
    }
}
