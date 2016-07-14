using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibraries
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Health { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte Speed { get; set; }
        public byte SpecialAttack { get; set; }
        public byte SpecialDef { get; set; }
        UInt16 Experience;

        public Monster(string Name, byte Health, byte Attack, byte Defense, byte Speed, byte SpecialAttack, byte SpecialDef, UInt16 Experience)
        {
            this.Name = Name;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.SpecialAttack = SpecialAttack;
            this.SpecialDef = SpecialDef;
            this.Experience = Experience;
        }

        public Monster()
        {

        }
        public Monster(string Name, byte Health, byte Attack, byte Defense, byte Speed, byte SpecialAttack, byte SpecialDef)
        {
            this.Name = Name;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.SpecialAttack = SpecialAttack;
            this.SpecialDef = SpecialDef;
        }
    }
}
