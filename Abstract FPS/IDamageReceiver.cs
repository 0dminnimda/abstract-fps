using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_FPS
{
    public interface IDamageReceiver
    {
        void TakeDamageFrom(IDamageDealer damageDealer);
    }
}