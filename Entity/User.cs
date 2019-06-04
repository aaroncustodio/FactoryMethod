using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class User : BaseClass
    {
        private string name;
        private string gender;
        private DateTime birthday;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
