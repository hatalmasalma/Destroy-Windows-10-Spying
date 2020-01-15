using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWS.lib
{
    public static class Paths
    {
        public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);
        public static string ShellCmdLocation =
            File.Exists(SysDir + @"Windows\Sysnative\cmd.exe") ?
                SysDir + @"Windows\Sysnative\cmd.exe" : SysDir + @"Windows\System32\cmd.exe";
    }
}
