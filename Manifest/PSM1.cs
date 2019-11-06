using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manifest
{
    //  v0.01.005
    class PSM1
    {
        //const string EXTENSION = ".psm1";
        //public static void Create(string projectName, string outputDir)
        public static void Create(ProjectInfo info)
        {
            //string dllFile = Path.Combine(outputDir, projectName + ".dll");
            //string outputFile = Path.Combine(outputDir, projectName + EXTENSION);
            if (!File.Exists(info.DllFile)) { return; }
            using (StreamWriter sw = new StreamWriter(info.Psm1File, false, Encoding.UTF8))
            {
                sw.WriteLine();
            }
        }
    }
}
