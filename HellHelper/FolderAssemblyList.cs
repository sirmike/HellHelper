using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HellHelper
{
    public partial class FolderAssemblyList : Form
    {
        public List<string> Assemblies { get; set; }

        public FolderAssemblyList()
        {
            InitializeComponent();
        }

        private void FolderAssemblyList_Load(object sender, EventArgs e)
        {
            foreach (string ass in Assemblies)
            {
                assemblyList.Text += ass;
                assemblyList.Text += Environment.NewLine;
            }
        }

        private void FolderAssemblyList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
