using System;

namespace _15112021
{
    class Program
    {
        static void Main(string[] args)
        {

            UserValidator userValidator = new UserValidator();

            Console.WriteLine("Username daxil edin:");
            string username = Console.ReadLine();

            if (!userValidator.CheckUserName(username))
            {
                Console.WriteLine("Username yanlisdir!");
                return;
            }

            Console.WriteLine("Password daxil et:");
            string pass = Console.ReadLine();

            if (!userValidator.CheckPassword(pass))
            {
                Console.WriteLine("Password yanlisdir!");
                return;
            }

            User user = new User();
            user.Password = pass;
            user.UserName = username;

            UserCRUD userData = new UserCRUD();

            userData.Create(user);
            userData.Create(new User { UserName = "test1", Password = "pass1345565" });
            userData.Remove(1);

            foreach (var item in userData.GetList())
            {
                Console.WriteLine(item.UserName);
            }
        }
    }
}
