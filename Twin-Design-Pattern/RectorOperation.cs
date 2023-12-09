using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twin_Design_Pattern
{
    public class RectorOperation : IOperation
    {
        public string SetEmailAddress(string emailAddress)
        {
            const string domain = "rectoraccount.com";
            string[] array = emailAddress.Split('@');
            emailAddress = array[0] + domain;
            return emailAddress;
        }

        public void GetFullName()
        {
            Console.WriteLine("Rector FullName");
        }

        public Guid GetGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid;
        }

        public PermissionTypes GetPermissionType()
        {
            PermissionTypes type = PermissionTypes.Rector;
            Console.WriteLine(type);
            return type;
        }
    }
}
