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
    public partial class MonsterCreator : Form
    {
        #region Variables
        List<Monster> PokeMonsters = new List<Monster>();///Collection of Monster Objects
        string PokeMonsterFile;                          ///Full String with all objects
        Monster newMonster = new Monster();              ///Monster Object

        #endregion
        public MonsterCreator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokeMonsterFile = System.IO.File.ReadAllText(@"C:\Poke.txt");   ///Load in string from save file
            PokeMonsters = JsonConvert.DeserializeObject<List<Monster>>(PokeMonsterFile);///unformat into our collection
            bindingSource1.DataSource = PokeMonsters;                       ///Update Binding Source with our save file
        }

        void Save()
        {
            string Json = JsonConvert.SerializeObject(PokeMonsters);        ///Create a Json Formatted String of Monster Objection Collection
            System.IO.File.WriteAllText(@"C:\Poke.txt", Json);              ///Write File of Json formatted string to 
        }

        void saveToolStripButton_Click(object sender, System.EventArgs e)
        {
            Save();
        }

    }
}
