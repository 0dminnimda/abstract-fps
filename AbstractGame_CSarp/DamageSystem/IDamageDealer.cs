using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageSystem
{
    /// <remarks>
    /// No "damage dealer" should refer to more than one IDamageDealer,
    /// everything should be described using the Damage function and status of the IDamageReceiver.
    /// </remarks>
    public interface IDamageDealer
    {
        // IDamagePattern damagePattern { get; }

        /// <summary>
        /// uses damagePattern to damage damageReceiver
        /// </summary>
        void Damage(IDamageReceiver damageReceiver);
    }
}