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

    public class Abilities
    {
        private char mType;
        ///A - Attack, M- Magic Attack
        ///D - Defence Boost, N- Magic Defend
        ///H - Heal
        private string _Modifier;
        ///Water, Fire, Wind
        private byte _Power;
        ///Base Power
        private byte _Cost;
        ///Cost of Ability
        private string _Name;
        ///Name of Ability 
        private byte _BaseSpeed;
        private byte _Acc;

        public char Type
        {
            get { return mType; }
            set { mType = value; }
        }

        public string Modifier
        {
            get { return _Modifier; }
            set { _Modifier = value; }
        }

        public byte Power
        {
            get { return _Power; }
            set { _Power = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public byte Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        public byte BaseSpeed
        {
            get { return _BaseSpeed; }
            set { _BaseSpeed = value; }
        }

        public byte Acc
        {
            get { return _Acc; }
            set { _Acc = value; }
        }



        public Abilities()
        {

        }
    }
}
