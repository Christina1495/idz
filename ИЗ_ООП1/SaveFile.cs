using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ИЗ_ООП1
{
    class SaveFile
    {
        //if (File.Exists(sw2)) File.Delete(sw2);
        public void SaveAll(string sw2, string f)
        {      
            FileStream f2 = new FileStream(sw2, FileMode.Append);
            StreamWriter sw = new StreamWriter(f2);
            sw.WriteLine(f);
            sw.Close();
            f2.Close();
        }
            
    }
}
