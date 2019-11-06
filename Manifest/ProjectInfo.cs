using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifest
{
    public class ProjectInfo
    {
        public string ProjectName { get; set; } //  = "プロジェクト名を指定";
        public string DebugDir { get { return string.Format(@"..\..\..\{0}\bin\Debug", ProjectName); } }
        public string ReleaseDir { get { return string.Format(@"..\..\..\{0}\bin\Release", ProjectName); } }
        public string ModuleDir { get { return string.Format(@"..\..\..\{0}\bin\{0}", ProjectName); } }
        public string ModuleZip { get { return string.Format(@"..\..\..\{0}\bin\{0}.zip", ProjectName); } }
        public string ScriptDir { get { return string.Format(@"..\..\..\{0}\Script", ProjectName); } }
        public string FormatDir { get { return string.Format(@"..\..\..\{0}\Format", ProjectName); } }

        public ProjectInfo() { }
    }
}
