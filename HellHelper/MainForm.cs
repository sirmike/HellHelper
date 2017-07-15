using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace HellHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void lister_OnAssemblyLoad()
        {
            assListProgress.Increment(1);
        }

        void lister_OnAssembliesLoad(int numberOfAssemblies)
        {
            assListProgress.Maximum = numberOfAssemblies;
            assListProgress.Minimum = 0;
            assListProgress.Value = 0;
        }

        private string GetAssemblyListString(string path)
        {
            return "Assembly list for " + path;
        }

        private void AssListShowBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AssListPathSelector.Path))
            {
                return;
            }

            try
            {
                AssemblyLister lister = new AssemblyLister(AssListPathSelector.Path);
                lister.OnAssembliesLoad += new AssemblyLister.AllAssembliesLoad(lister_OnAssembliesLoad);
                lister.OnAssemblyProcessed += new AssemblyLister.AssemblyProcessed(lister_OnAssemblyLoad);
                lister.CreateAssembliesInfo();

                if (lister.Assemblies.Count < 1)
                {
                    MessageBox.Show("This folder does not contain .NET libraries.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FolderAssemblyList dialog = new FolderAssemblyList();
                dialog.Text = GetAssemblyListString(AssListPathSelector.Path);
                dialog.Assemblies = lister.GetNamesWithVersion();
                dialog.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot access path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void DependencyFindBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DependencyPathSelector.Path))
            {
                return;
            }

            try
            {
                AssemblyLister lister = new AssemblyLister(DependencyPathSelector.Path);
                lister.OnAssembliesLoad += new AssemblyLister.AllAssembliesLoad(Dependencies_OnAssembliesLoad);
                lister.OnAssemblyProcessed += new AssemblyLister.AssemblyProcessed(Dependencies_OnAssemblyProcessed);
                lister.CreateAssembliesInfo();
                List<AssemblyName> assemblies = lister.FindAssembliesThatReference(DependencyAssNameTB.Text, DependencyAssVersionTB.Text);
                if(assemblies != null && assemblies.Count > 0)
                {
                    FolderAssemblyList dialog = new FolderAssemblyList();
                    dialog.Text = GetAssemblyListString(DependencyPathSelector.Path);
                    dialog.Assemblies = assemblies.ToWikiStrings();
                    dialog.Show();
                }
                else
                {
                    MessageBox.Show("Specified assembly not found in references.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot access path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        void Dependencies_OnAssemblyProcessed()
        {
            DependencyProgress.Increment(1);
        }

        void Dependencies_OnAssembliesLoad(int numberOfAssemblies)
        {
            DependencyProgress.Maximum = numberOfAssemblies;
            DependencyProgress.Minimum = 0;
            DependencyProgress.Value = 0;
        }
    }
}
