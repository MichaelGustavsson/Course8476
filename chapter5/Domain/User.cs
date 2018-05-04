using System;

namespace chapter5.Domain
{
    public enum Role { Teacher, Student };
    public abstract class User
    {
        protected string passWord;

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password{
            set
            {
                if (!SetPassword(value))
                {
                    throw new ArgumentException("Password not complex enough.");
                }
            }
        }

        protected User()
        {
            //Create a dummy password
            this.passWord = Guid.NewGuid().ToString();
        }

        public abstract bool SetPassword(string pwd);

        public bool VerifyPassword(string pwd){
            return String.Compare(pwd, passWord) == 0;
        }
    }
}
