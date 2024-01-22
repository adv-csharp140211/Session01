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
            new User(1, "ali", "rezai", "inja@yeja.com", "222"),
            new User(2, "ali 2", "rezai", "inja@yeja.com", "222"),
            new User(3, "ali 3", "rezai", "inja@yeja.com", "222"),
        };
    }
}
