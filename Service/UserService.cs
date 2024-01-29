using App01.DataSource;
using App01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01.Service
{
    public class UserService
    {
        public int UserCount { get => InMemoryDB.Users.Count;  }
        public void Add(User user)
        {
            InMemoryDB.Users.Add(user);
        }

        public User GetByIndex(int index) { 
            return InMemoryDB.Users[index];
        }

        public void Update(User user, int index) {
            InMemoryDB.Users[index] =  user;
        }

        public void Remove(int index)
        {
            InMemoryDB.Users.RemoveAt(index);
        }
    }
}
