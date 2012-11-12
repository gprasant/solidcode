using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.Before
{
    public abstract class Animal 
    {
        public abstract void Groom();
        public abstract void Feed();
    }

    public class Dog : Animal
    {
        public override void Feed()
        {
            //implement
        }

        public override void Groom()
        {
            //implement
        }
    }

    public class RattleSnake : Animal //????
    {
        public override void Feed()
        {
            //implement
        }

        public override void Groom()
        {
            throw new NotImplementedException();
        }
    }
}
