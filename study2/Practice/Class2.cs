using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CS11
{
    class Class2
    {
        public string FirstName;
        public string LastName;

        public string GetFullName()
        {
            return LastName + FirstName;
        }
        
        
        
        public void main()
        {
            Class2 player = new Class2 ();
            player.LastName = "高田";
            player.FirstName = "俊";

            Console.WriteLine(GetFullName);
        }
    }
    class Customer
    {
        public string FirstName;
        public string LastName;

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Customer(string lastName) : this("--", lastName)
        {

        }
        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}


