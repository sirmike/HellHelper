using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HellHelper
{
    static class Extensions
    {
        public static string ToWikiString(this AssemblyName assemblyName)
        {
            return string.Format("* {0} {1}", assemblyName.Name, assemblyName.Version);
        }

        public static List<string> ToWikiStrings(this List<AssemblyName> assemblies)
        {
            List<string> result = new List<string>();
            foreach (AssemblyName name in assemblies)
            {
                result.Add(name.ToWikiString());
            }
            result.Sort();
            return result;
        }
    }
}
