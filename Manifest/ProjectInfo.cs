﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifest
{
    public enum Mode { Debug, Release }

    public class ProjectInfo
    {
        //  プロジェクト名を指定
        const string PROJECT_NAME = "";

        //  デバッグ/リリースのモード指定
        public Mode Mode { get; set; }

        public string TargetDir { get { return string.Format(@"..\..\..\{0}\bin\{1}", PROJECT_NAME, Mode); } }
        public string ModuleDir { get { return string.Format(@"..\..\..\{0}\bin\{0}", PROJECT_NAME); } }
        public string ModuleZip { get { return string.Format(@"..\..\..\{0}\bin\{0}.zip", PROJECT_NAME); } }
        public string ScriptDir { get { return string.Format(@"..\..\..\{0}\Script", PROJECT_NAME); } }
        public string FormatDir { get { return string.Format(@"..\..\..\{0}\Format", PROJECT_NAME); } }
        public string HelpDir { get { return string.Format(@"..\..\..\{0}\Help", PROJECT_NAME); } }
        public string CmdletDir { get { return string.Format(@"..\..\..\{0}\Cmdlet", PROJECT_NAME); } }

        public string DllFile { get { return string.Format(@"..\..\..\{0}\bin\{1}\{0}.dll", PROJECT_NAME, Mode); } }
        public string Psd1File { get { return string.Format(@"..\..\..\{0}\bin\{1}\{0}.psd1", PROJECT_NAME, Mode); } }
        public string Psm1File { get { return string.Format(@"..\..\..\{0}\bin\{1}\{0}.psm1", PROJECT_NAME, Mode); } }

        public string Description { get; set; }     //  = "プロジェクトの説明";
        public string Author { get; set; }          //  = "作成者";
        public string CompanyName { get; set; }     //  = "会社名";
        public string Copyright { get; set; }       //  = "コピーライト";

        public string[] ExcludeCmdlet { get; set; } //  = new string[]{ "コマンドレット登録除外対象の*.cs" }
        public ExternalPackage[] ExternalPackages { get; set; }     //  = new ExternalPackage[]{ new ExternalPackage() { その他追加パッケージ } }

        public ProjectInfo() { }
    }
}
