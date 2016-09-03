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
        Binding imagebinding;
        #endregion
        public MonsterCreator()
        {
            InitializeComponent();
            imagebinding = new Binding("Image", this.bindingSource1, "Image", true);
            imagebinding.Format += imagebinding_Format;
            pictureBox1.DataBindings.Add(imagebinding);
        }

        void imagebinding_Format(object sender, ConvertEventArgs e)
        {
            ((byte[])e.Value).ByteArrayToImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PokeMonsterFile = System.IO.File.ReadAllText(@"C:\Poke.txt");   ///Load in string from save file
                PokeMonsters = JsonConvert.DeserializeObject<List<Monster>>(PokeMonsterFile);///unformat into our collection
            }
            catch
            {
                PokeMonsters.Add(new Monster("Default", 0, 0, 0, 0, 0, 0, null));
            }

            bindingSource1.DataSource = PokeMonsters;                       ///Update Binding Source with our save file
        }

        void Save()
        {
            PokeMonsters.Sort((l, r) => 1 * l.Name.CompareTo(r.Name));      ///On save, will resort the list alphabetically 

            string Json = JsonConvert.SerializeObject(PokeMonsters);        ///Create a Json Formatted String of Monster Objection Collection
            System.IO.File.WriteAllText(@"C:\Poke.txt", Json);              ///Write File of Json formatted string to 
        }

        void saveToolStripButton_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            System.Windows.Forms.DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                // Construct an image object from a file in the local directory.
                // ... This file must exist in the solution.
                Image image = Image.FromFile(openFileDialog1.FileName);
                // Set the PictureBox image property to this image.
                // ... Then, adjust its height and width properties.
                pictureBox1.Image = image;
                pictureBox1.Height = image.Height;
                pictureBox1.Width = image.Width;
                ((Monster)bindingSource1.Current).Image = image.imageToByteArray();
            }
        }


    }
}
