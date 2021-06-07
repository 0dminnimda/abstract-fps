using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageSystem
{
    public abstract class DamageDealer : IDamageDealer
    {
        public abstract IDamagePattern damagePattern { get; }

        public void Damage(IDamageReceiver damageReceiver)
        {
            damageReceiver.TakeDamageFrom(this);
        }
    }
}