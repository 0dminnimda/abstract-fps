using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageSystem
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