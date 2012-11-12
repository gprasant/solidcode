using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.After
{
    public interface IPet
    {
        void Groom();
    }

    public abstract class Animal
    {
        public abstract void Feed();
    }
}
