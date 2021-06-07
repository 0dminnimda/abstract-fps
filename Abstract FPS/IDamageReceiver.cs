using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_FPS
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
    }
}