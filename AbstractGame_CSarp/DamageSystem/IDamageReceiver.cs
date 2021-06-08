using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageSystem
{
    /// <summary>
    /// Shold keep track of .. some health info
    /// </summary>
    public interface IDamageReceiver
    {
        /// <summary>
        /// kinda should be internal ..
        /// </summary>
        int healthStorage { get; }
        int infoImportantForDamage { get; set; }

        void TakeDamageFrom(IDamageDealer damageDealer);
        /// <summary>
        /// takes health info and handles damage
        /// </summary>
        void TakeDamage();
    }
}