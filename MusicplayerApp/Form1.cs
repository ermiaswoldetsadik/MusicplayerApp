using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicplayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //create array to save titles or name of songs
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple file
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save the names of songs in files array
                paths = ofd.FileNames;//saves the path of songs in path array
                //display music in listsongs
                for(int i = 0;i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);//display songs in listbox
                }

            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play songs
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the app
            this.Close();
        }
    }
}
