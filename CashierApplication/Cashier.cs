using System;
using System.Collections.Generic;
using System.Text;

namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            return uName == user_name && password == user_password;
        }

        public string getDepartment()
        {
            return department;
        }
    }

}
