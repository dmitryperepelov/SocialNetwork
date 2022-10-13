using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья");

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine($"E-mail: {friend.Email}. Имя: {friend.FirstName}. Фамилия: {friend.LastName}");
            });

            }

        }
}

