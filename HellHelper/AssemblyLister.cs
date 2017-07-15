using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace HellHelper
{
    class AssemblyLister
    {
        private string path = string.Empty;
        public List<AssemblyName> Assemblies { get; set; }

        public delegate void AllAssembliesLoad(int numberOfAssemblies);
        public delegate void AssemblyLoaded();
        public delegate void AssemblyProcessed();

        public event AllAssembliesLoad OnAssembliesLoad;
        public event AssemblyProcessed OnAssemblyProcessed;

        public AssemblyLister(string path)
        {
            this.path = path;
            Assemblies = new List<AssemblyName>();
        }

        public void CreateAssembliesInfo()
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            string[] files = Directory.GetFiles(path, "*.dll", SearchOption.AllDirectories);
            if (files != null && OnAssembliesLoad != null)
            {
                OnAssembliesLoad(files.Length);
            }

            foreach (string file in files)
            {
                try
                {
                    if (OnAssemblyProcessed != null)
                    {
                        OnAssemblyProcessed();
                    }
                    AssemblyName an = AssemblyName.GetAssemblyName(file);
                    Assemblies.Add(an);
                }
                catch (BadImageFormatException)
                {
                    if (OnAssemblyProcessed != null)
                    {
                        OnAssemblyProcessed();
                    }
                }
                catch (FileLoadException)
                {
                    if (OnAssemblyProcessed != null)
                    {
                        OnAssemblyProcessed();
                    }
                }
            }
        }

        public List<string> GetNamesWithVersion()
        {
            List<string> result = new List<string>();
            foreach (AssemblyName name in Assemblies)
            {
                result.Add(name.ToWikiString());
            }
            result.Sort();
            return result;
        }

        public List<AssemblyName> FindAssembliesThatReference(string assemblyName, string version)
        {
            if (string.IsNullOrEmpty(assemblyName))
            {
                return null;
            }

            List<AssemblyName> result = new List<AssemblyName>();
            foreach (AssemblyName name in Assemblies)
            {
                if (OnAssemblyProcessed != null)
                {
                    OnAssemblyProcessed();
                }
                Assembly assembly = Assembly.Load(name);
                AssemblyName[] references = assembly.GetReferencedAssemblies();
                foreach (AssemblyName reference in references)
                {
                    if (reference.Name.ToLower() == assemblyName.ToLower())
                    {
                        if (!string.IsNullOrEmpty(version))
                        {
                            if (reference.Version.ToString() == version)
                            {
                                result.Add(name);
                            }
                        }
                        else
                        {
                            result.Add(name);
                        }
                        break;
                    }
                }
            }
            return result;
        }
    }
}
