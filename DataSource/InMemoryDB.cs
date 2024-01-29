using App01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01.DataSource
{
    /*
     * static
     *  new nadarim
     *  
     *  usage
     *      single user
     *          data ✔️
     *      multi user
     *          data ❌
     *
     *      utitly
     *  
     */
    public static class InMemoryDB
    {
        ///USER

        public static List<User> Users = new List<User> {
            new User{Id = 1, FirstName = "ali 1", LastName = "rezai 1", Email = "inja@yeja.com", Tel = "222"},
            new User{Id = 2, FirstName = "ali 2", LastName = "rezai 2", Email = "inja@yeja.com", Tel = "222"},
            new User{Id = 3, FirstName = "ali 3", LastName = "rezai 3", Email = "inja@yeja.com", Tel = "222"},
        };
    }
}
