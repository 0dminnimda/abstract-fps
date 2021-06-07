using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_FPS
{
    public abstract class DamageReceiver : IDamageReceiver
    {
        public void TakeDamageFrom(IDamageDealer damageDealer)
        {
            throw new NotImplementedException();
        }
    }
}