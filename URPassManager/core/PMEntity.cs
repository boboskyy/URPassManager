using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URPassManager.core
{
    internal class PMEntity
    {
        public string URL { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public PMEntity(string uRL, string username, string password)
        {
            URL = uRL;
            Username = username;
            Password = password;
        }
    }
}
