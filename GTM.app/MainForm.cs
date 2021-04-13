using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTM.app.Game;

namespace GTM.app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            GameConnection.RootFolder = "X:\\Games\\SteamLibrary\\steamapps\\common\\Grand Tactician The Civil War (1861-1865)";
            InitializeComponent();
            this.GameFolder.Text = "X:\\Games\\SteamLibrary\\steamapps\\common\\Grand Tactician The Civil War (1861-1865)";
        }

        private void GameFolderButton_Click(object sender, EventArgs e)
        {
            string gameFolder = Jeeves.GetGTFolder();
            this.GameFolder.Text = gameFolder;
            GameConnection.RootFolder = gameFolder;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameConnection.GetLastSave();
        }
    }
}
