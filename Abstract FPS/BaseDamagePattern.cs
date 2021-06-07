using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_FPS
{
    internal abstract class BaseDamagePattern : IDamagePattern
    {
        public void ApplyOn(string damageReceiver)
        {
            throw new NotImplementedException();
        }
    }
}