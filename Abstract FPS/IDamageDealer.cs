using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_FPS
{
    public interface IDamageDealer
    {
        IDamagePattern damagePattern { get; }

        /// <summary>
        /// uses damagePattern to damage damageReceiver
        /// </summary>
        void Damage(IDamageReceiver damageReceiver);
    }
}