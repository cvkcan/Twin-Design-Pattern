using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twin_Design_Pattern
{
    public interface IOperation
    {
        Guid GetGuid();
        string SetEmailAddress(string emailAddress);
        void GetFullName();
        PermissionTypes GetPermissionType();
    }
}
