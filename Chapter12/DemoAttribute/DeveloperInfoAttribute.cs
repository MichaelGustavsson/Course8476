using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperInfoAttribute: Attribute
    {
        private string _email;

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public DeveloperInfoAttribute(string emailAddress)
        {
            this._email = emailAddress;
        }
    }
}
