using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1089_1105_1116_IMS.Classes.Person
{
    public abstract class Person
    {
        protected string FirstName;
        protected string LastName;
        protected string Address;
        protected string Telephone;
        protected string Type;

        public Person(string f, string l, string a, string tel, string t)
        {
            this.FirstName = f;
            this.LastName = l;
            this.Address = a;
            this.Telephone = tel;
            this.Type = t;
        }
    }
}
