using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTest
{
    public abstract class Base
    {
        public virtual void Virtual() { }
        public abstract void Abstract();
        public void None() { }
    }
}
