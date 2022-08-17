using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    public class ChildClass : BaseClass, IParent
    {
        public ChildClass()
        {
            
        }

        public void AddMethod()
        {
            //
        }

        public double GiveAccount()
        {
            throw new NotImplementedException();
        }
    }
}
