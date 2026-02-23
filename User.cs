using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevantaApp
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        //Constructor with two parameters
        public User(string name, string email)
        {  
            Name = name; 
            Email = email; 
        }

        //Override ToString() for displaying in the ListBox
        public override string ToString()
        {
            return $"{Name} - {Email}";
        }
    }
}
