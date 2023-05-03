using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    public static class Actions
    {
        public static void AddUser() // warunki potem czyli jakieś hasła styl username własny i mail dla każdego nowego
        {
            var username = Console.ReadLine() ?? string.Empty;
            var password = Console.ReadLine() ?? string.Empty;
            var email = Console.ReadLine() ?? string.Empty;

            Data.UserData = new User(username, email, password);
        } 

        public static void RemoveUser(string account)
        {
            foreach(string username in Data.UserList.Keys)
            {
                if(username == account) // hasło jeszcze
                {
                    Data.UserList.Remove(username);
                    return;
                }
            }
        }

        //z usera tutaj przerzucić
    }
}
