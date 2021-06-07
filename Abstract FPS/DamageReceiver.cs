using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_FPS
{
    public abstract class DamageReceiver : IDamageReceiver
    {
        public int healthStorage { get => throw new NotImplementedException(); }
        public int infoImportantForDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void TakeDamage()
        {
            throw new NotImplementedException();
        }

        public void TakeDamageFrom(IDamageDealer damageDealer)
        {
            throw new NotImplementedException();
        }
    }
}