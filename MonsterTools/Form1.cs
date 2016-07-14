using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonsterLibraries;
using Newtonsoft.Json;

namespace MonsterTools
{
    public partial class Form1 : Form
    {
        #region Variables
        List<Monster> PokeMonsters = new List<Monster>();///Collection of Monster Objects
        string PokeMonsterFile;                          ///Full String with all objects
        Monster newMonster = new Monster();              ///Monster Object

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Json = JsonConvert.SerializeObject(PokeMonsters);        ///Create a Json Formatted String of Monster Objection Collection
            System.IO.File.WriteAllText(@"C:\Poke.txt", Json);              ///Write File of Json formatted string to 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokeMonsterFile = System.IO.File.ReadAllText(@"C:\Poke.txt");   ///Load in string from save file
            PokeMonsters = JsonConvert.DeserializeObject<List<Monster>>(PokeMonsterFile);///unformat into our collection
            bindingSource1.DataSource = PokeMonsters;                       ///Update Binding Source with our save file
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Position > 0)
                bindingSource1.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Position < bindingSource1.Count)
                bindingSource1.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PokeMonsters.Add(new Monster());
            bindingSource1.MoveLast();
        }
    }
}
