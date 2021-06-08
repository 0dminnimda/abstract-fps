using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageSystem
{
    internal abstract class BaseDamagePattern : IDamagePattern
    {
        public void ApplyOn(IDamageReceiver damageReceiver)
        {
            // check .. enemy type? (and not only this)
            if (damageReceiver.infoImportantForDamage == 5)
            {
                // damage set to n
            }
            else
            {
                // damage set to m
            }

            // when damage caclulated
            damageReceiver.TakeDamage();


            // damage can be received over time
            // wait 5 sec
            damageReceiver.TakeDamage();

            // maybe change some states, may be dangerous, idk
            damageReceiver.infoImportantForDamage = 6;
        }
    }
}