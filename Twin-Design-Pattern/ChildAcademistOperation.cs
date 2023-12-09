using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twin_Design_Pattern
{
    public class ChildAcademistOperation : AcademistOperation
    {
        public ChildRectorOperation ChildRectorOperation {  get; set; } 
    }
}
