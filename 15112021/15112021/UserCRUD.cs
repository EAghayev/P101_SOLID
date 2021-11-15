using System;
using System.Collections.Generic;
using System.Text;

namespace _15112021
{
    class UserCRUD
    {
        public void Create(User user)
        {
            Data.Users.Add(user);
        }

        public void Remove(int index)
        {
            Data.Users.RemoveAt(index);
        }

        public List<User> GetList()
        {
            return Data.Users;
        }
    }
}
