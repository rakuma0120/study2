using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    public class Person
    {
        private string name;
        private int age;


        public Person(string test1, int test2)
        {
            this.name = test1;
            this.age = test2;
        }

        public void 自己紹介()
        {
            Debug.WriteLine("私の名前は" + name + "です！");
        }

    }
}
