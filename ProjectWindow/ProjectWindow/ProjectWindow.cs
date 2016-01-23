using Controllers;
using ProjectWindow.Icons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWindow
{
    public partial class ProjectWindow : Form
    {
        public ProjectWindow()
        {
            InitializeComponent();

            LoadTestIcons();
        }

        public void LoadTestIcons()
        {
            PSIcon psicons = PSIcon.GetInstance();

            psicons.Load();

            for (int i = 0; i < 5; i++)
            {
                PictureBox pb = new PictureBox();
                Image img = psicons.GetIcon(PSIcon.MEMBER); 
                pb.Image = img;
                pb.BorderStyle = BorderStyle.Fixed3D;
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                pb.Location = new Point(i * (img.Width + 12) + 12, 12);

                pb.Click += (sender, args) =>
                {
                    lblStatus.Text = i + " was clicked";
                };

                tabOverview.Controls.Add(pb);
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
