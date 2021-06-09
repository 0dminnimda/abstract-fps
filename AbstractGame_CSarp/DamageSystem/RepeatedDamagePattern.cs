using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{
    // i start thinking that we can just use functions instead

    class RepeatedDamagePattern : IDamagePattern
    {
        readonly int numberOfRepetitions;
        readonly int timeBetweenDamage;
        readonly int damage;

        public RepeatedDamagePattern(int numberOfRepetitions, int timeBetweenDamage, int damage)
        {
            this.numberOfRepetitions = numberOfRepetitions;
            this.timeBetweenDamage = timeBetweenDamage;
            this.damage = damage;
        }

        public void ApplyOn(IDamageReceiver damageReceiver)
        {
            for (var i = 0; i < numberOfRepetitions; i++)
            {
                // damage
                damageReceiver.TakeDamage();

                // wait timeBetweenDamage seconds ..
            }
        }
    }
}
