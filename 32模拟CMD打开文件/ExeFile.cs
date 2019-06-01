using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32模拟CMD打开文件
{
    class ExeFile:FIleFather
    {
        public ExeFile(String fullpath) : base(fullpath) { 
        
        }
        public override void OpenFile()
        {
            Process p = new Process();
            ProcessStartInfo pis = new ProcessStartInfo(FullPath);
            p.StartInfo = pis;
            p.Start();
        }
    }
}
