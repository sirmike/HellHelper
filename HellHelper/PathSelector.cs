using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HellHelper
{
    public partial class PathSelector : UserControl
    {
        public PathSelector()
        {
            InitializeComponent();
        }

        public string Path
        {
            get
            {
                return PathTB.Text;
            }
            set
            {
                PathTB.Text = value;
            }
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.SelectedPath = Config.Default.InitialDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Path = dialog.SelectedPath;
                    Config.Default.InitialDirectory = Path;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot process selected folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
