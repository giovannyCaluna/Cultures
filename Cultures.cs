using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultures
{
    public partial class Cultures : Form
    {
        Properties.Settings settings;
        public Cultures()
        {
            InitializeComponent();

            settings = new Properties.Settings();
            Application.CurrentCulture = new CultureInfo(settings.Culture);

            ChangeSkin();
        }

        void ChangeSkin()
        {
            ResourceManager rm = new ResourceManager(
                "Cultures.Cultures",
                Assembly.GetExecutingAssembly());

            pictureBox1.Image = 
                (Image) rm.GetObject("Flag", Application.CurrentCulture);
            fileToolStripMenuItem.Text = 
                (string)rm.GetObject("FileMenu", Application.CurrentCulture);
            openToolStripMenuItem.Text =
                (string)rm.GetObject("OpenMenu", Application.CurrentCulture);
            exitToolStripMenuItem.Text =
                (string)rm.GetObject("ExitMenu", Application.CurrentCulture);
        }

        private void uSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Culture = "hu-HU";
            Application.CurrentCulture = new CultureInfo(settings.Culture);
            ChangeSkin();
        }

        private void hungaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Culture = "hu-HU";
            Application.CurrentCulture = new CultureInfo(settings.Culture);
            ChangeSkin();
        }

        private void russiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Culture = "ru-RU";
            Application.CurrentCulture = new CultureInfo(settings.Culture);
            ChangeSkin();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cultures_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Save();
        }
    }
}
