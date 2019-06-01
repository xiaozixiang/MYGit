using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32模拟CMD打开文件
{
    class JpgFile:FIleFather
    {
        public JpgFile(String fullpath) : base(fullpath) { 
        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
}
