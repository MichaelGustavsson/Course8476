using DemoAttribute;
using HumanResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Department);

            var attribute = Attribute.GetCustomAttribute(
                type, typeof(DeveloperInfoAttribute)) as DeveloperInfoAttribute;

            Console.WriteLine("");

            if (attribute == null)
            {
                Console.WriteLine("Couldn't find the attribute");
            }
            else
            {
                Console.WriteLine("Attribute Email: {0}", attribute.Email);
            }

            Console.WriteLine("");

        }
    }    
}
