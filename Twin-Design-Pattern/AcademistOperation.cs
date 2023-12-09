using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twin_Design_Pattern
{
    public class AcademistOperation : IOperation
    {
        public string SetEmailAddress(string emailAddress)
        {
            const string domain = "academistaccount.com";
            string[] array = emailAddress.Split('@');
            emailAddress = array[0] + domain;
            return emailAddress;
        }

        public void GetFullName()
        {
            //DoSomething();
            Console.WriteLine("Academist FullName");
        }

        public Guid GetGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid;
        }

        public PermissionTypes GetPermissionType()
        {
            PermissionTypes type = PermissionTypes.Academist;
            Console.WriteLine(type);
            return type;
        }
    }
}
