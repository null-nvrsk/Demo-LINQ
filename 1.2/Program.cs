using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            //var selectedUsers = from user in users
            //                    where user.Age > 25
            //                    select user;
            var selectedUsers = users.Where(u => u.Age > 25);

            foreach (User user in selectedUsers)
                Console.WriteLine($"|{user.Name}\t|{user.Age}\t|");

            Console.WriteLine("\n----------------\n");

            selectedUsers = from user in users
                            from lang in user.Languages
                            where user.Age < 28
                            where lang == "английский"
                            select user;

            // Для меня метод расширения кажется более сложным
            //selectedUsers = users.SelectMany(u => u.Languages,
            //                        (u, l) => new { User = u, Lang = l })
            //                      .Where(u => u.Lang == "английский" && u.User.Age < 28)
            //                      .Select(u => u.User);

            foreach (User user in selectedUsers)
                Console.WriteLine($"|{user.Name}\t|{user.Age}\t|");

            Console.WriteLine("\n----------------\n");

            Console.ReadKey();
        }
    }
}
