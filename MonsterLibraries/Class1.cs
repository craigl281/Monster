using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace MonsterLibraries
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Health
        {
            get
            {
                return _Health;
            }
            set
            {
                if (value > 0 && value < 255)
                    _Health = value;
                else
                    System.Windows.Forms.MessageBox.Show("Enter a number from 0 - 255");
            }
        }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte Speed { get; set; }
        public byte SpecialAttack { get; set; }
        public byte SpecialDef { get; set; }
        UInt16 Experience;
        private byte _Health { get; set; }
        private byte[] _image;

        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }


        public Monster(string Name, byte Health, byte Attack, byte Defense, byte Speed, byte SpecialAttack, byte SpecialDef, byte[] Image, UInt16 Experience)
        {
            this.Name = Name;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.SpecialAttack = SpecialAttack;
            this.SpecialDef = SpecialDef;
            this.Image = Image;
            this.Experience = Experience;
        }

        public Monster()
        {

        }
        public Monster(string Name, byte Health, byte Attack, byte Defense, byte Speed, byte SpecialAttack, byte SpecialDef, byte[] Image)
        {
            this.Name = Name;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.SpecialAttack = SpecialAttack;
            this.SpecialDef = SpecialDef;
            this.Image = Image;
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

        private byte _Crit;

        public byte Crit
        {
            get { return _Crit; }
            set { _Crit = value; }
        }

        

        public Abilities()
        {

        }

        public Abilities(string Nameofmove, char Type, string Modifier, byte Power, byte Cost, byte Speed, byte Accuracy)
        {
            this.Name = Nameofmove;
            this.Type = Type;
            this.Modifier = Modifier;
            this.Power = Power;
            this.Cost = Cost;
            this.BaseSpeed = Speed;
            this.Acc = Accuracy;
        }
    }

    public static class Extensions
    {
        public static byte[] imageToByteArray(this Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(this byte[] bytearray)
        {
            if (bytearray == null)
                return null;
            using (var ms = new MemoryStream(bytearray))
            {
                return Image.FromStream(ms);
            }
        }

        public static T Deserialize<T>(byte[] data) where T : class
        {
            using (var stream = new MemoryStream(data))
            using (var reader = new StreamReader(stream))
                return JsonSerializer.Create().Deserialize(reader, typeof(T)) as T;
        }


    }
}