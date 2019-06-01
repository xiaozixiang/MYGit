using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32模拟CMD打开文件
{
   public abstract class FIleFather
    {
       public String FullPath
       {
           set;
           get;
       }
       public FIleFather(String fullpath) {
           this.FullPath = fullpath;
       }
       public abstract void OpenFile();
    }
}
